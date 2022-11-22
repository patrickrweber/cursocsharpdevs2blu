var listCharacter = new Array();
const LISTA_PERSONAGENS = "lista_personagens";

addEventListener("load", function () {});

$(document).ready(() => {
  getPagina("_views/home.html", "main");
  getAPI(URL_API_CHARACTER, criaListaCharacterHome);

  $("#btn-galeria").click((e) => {
    getPagina("_views/galeria.html", "main");
    getAPI(URL_API_CHARACTER, criaListaCharacter);
  });

  $("#btn-index").click((e) => {
    getPagina("_views/home.html", "main");
    getAPI(URL_API_CHARACTER, criaListaCharacterHome);
  });
});

function Search() {
  var search = $("#searchBar").val();
  listSearchPerson = JSON.parse(getItem("lista_personagens"));

  for (var i = 0; i < listSearchPerson.length; i++) {
    if (listSearchPerson[i].name.toUpperCase().includes(search.toUpperCase())) {
      mostraDetalhesCharacter(listSearchPerson[i]);
      return;
    }
  }
}

const criaListaCharacter = (data) => {
  let main = getElement("#main-galeria");

  data.forEach((character) => {
    let html = document.createElement("li");
    html.classList.add("card", "col-2", "hvr-grow");
    html.addEventListener("click", () => mostraDetalhesCharacter(character));

    let htmlBody = `
                <div>
                    <div class="card-header">
                        <img class="card-img-top card-img" src="${character.image}" alt="${character.name}">
                    </div>
                    <div class="card-body">
                        <h2 class="text-secondary text-center">${character.name}</h2>
                    </div>
                </div>`;

    html.innerHTML = htmlBody;
    main.appendChild(html);

    personagens = {
      id: character.char_id,
      name: character.name,
      gender: character.gender,
      image: character.image,
      hairColor: character.hairColor,
      firstEpisode: character.firstEpisode,
      voicedBy: character.voicedBy,
      occupation: character.occupation,
    };

    listCharacter.push(personagens);
  });
  salvarPersonagens(listCharacter);
};

// Galeria na MAIN
const criaListaCharacterHome = (data) => {
  let main = getElement("#main-home");

  data.forEach((character, i) => {
    if (i < 5) {
      let html = document.createElement("li");
      html.classList.add("card", "col-2", "hvr-grow");
      html.addEventListener("click", () => mostraDetalhesCharacter(character));

      let htmlBody = `
                  <div>
                      <div class="card-header">
                          <img class="card-img-top card-img" src="${character.image}" alt="${character.name}">
                      </div>
                      <div class="card-body">
                          <h2 class="text-secondary text-center">${character.name}</h2>
                      </div>
                  </div>`;

      html.innerHTML = htmlBody;
      main.appendChild(html);
    }
  });
};

const mostraDetalhesCharacter = (character) => {
  let div = document.createElement("div");
  getElement("#modal-body").innerHTML = "";
  div.classList.add("card-modal", "col-12", "my-4");

  let cardBody = `
            <div class="card-header card-header-modal">
                <img class="card-img-top" src="${character.image}" alt="Foto Personagem">
            </div>
            <div class="card-body bg-white">
                <h1 class="text-secondary text-center">${character.name}</h1>
                <article>
                    <ul class="list-group">
                        <li class="list-group-item">Gênero: ${character.gender}</li>
                        <li class="list-group-item">Cor do cabelo: ${character.hairColor}</li>
                        <li class="list-group-item">Ocupação: ${character.occupation}</li>
                        <li class="list-group-item">Primeiro episódio: ${character.firstEpisode}</li>
                        <li class="list-group-item">Dublador: ${character.voicedBy}</li>
                    </ul>
                </article>
            </div>
        `;
  div.innerHTML = cardBody;
  getElement("#modal-body").appendChild(div);

  $("#charModal").modal("show");
};

const salvarPersonagens = (listaPersonagens) => {
  setJsonItem(LISTA_PERSONAGENS, listaPersonagens);
};