var listCharacter = new Array();

$(document).ready(() => {
    $("#btn-home").ready((e) => {
      getPagina("index.html", "main");
    });
  
    $("#btn-galeria").click((e) => {
      getPagina("galeria.html", "main");
    });
  
    $("#btn-home").click((e) => {
      getPagina("index.html", "main");
    });
  
    $("#btn-home-logo").click((e) => {
      getPagina("index.html", "main");
    });
  });

addEventListener('load', function(){
    getAPI(URL_API_CHARACTER, criaListaCharacter);
});




const criaListaCharacter = (data) => {
    let main = getElement('main');
    console.log(data);
    listCharacter = new Array();

    data.forEach(character => {
        let html = document.createElement('div');
        html.classList.add('card-list', 'col-2', 'my-4', 'bg-customized', 'ms-1');
        html.addEventListener('click', ()=> mostraDetalhesCharacter(character))

        let htmlBody = `
        <div class="card-header">
            <img class="card-img-top" src="${character.image}" alt="${character.name} ">
        </div>
        <div class="card-body bg-white">
            <h2 class="text-primary text-center">${character.name}</h2>
        </div>`;

        html.innerHTML = htmlBody;
        main.appendChild(html);
        listCharacter.push(character);
    });

    gerarPaginacao(data.info);
}

const mostraDetalhesCharacter = (character) => {
    console.log(character);
    let div = document.createElement('div');
    getElement('#modal-body').innerHTML = "";
    div.classList.add('card', 'col-12', 'my-4', 'bg-dark');

    let cardBody = `
            <div class="card-header">
                <img class="card-img-top" src="${character.image}" alt="Rick">
            </div>
            <div class="card-body bg-white">
                <h1 class="text-primary text-center">${character.name}</h1>
                <article>
                    <ul class="list-group">
                        <li class="list-group-item">Gender: ${character.gender}</li>
                        <li class="list-group-item">Hair color: ${character.hairColor}</li>
                        <li class="list-group-item">Occpation: ${character.occupation}</li>
                        <li class="list-group-item">First Episode: ${character.firstEpisode}</li>
                        <li class="list-group-item">Voiced by: ${character.voicedBy}</li>
                    </ul>
                </article>
            </div>
        `;
        div.innerHTML = cardBody;
        getElement('#modal-body').appendChild(div);

        $('#charModal').modal('show');
}




