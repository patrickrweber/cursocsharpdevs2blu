const URL_API_CHARACTER = 'https://bobsburgers-api.herokuapp.com/characters/?limit=15'

var scripts = $('#scripts').clone();
/* # Functions*/
const getPagina = (url, target) => {
    $.ajax({
        url: `_html/${url}`,
        dataType: 'html',
        success: (pagina) => {
            $(target).html(pagina);
        }
    });
}

const getAPI = (url, functionCallback) => {
    fetch(url).then(
        (response) => response.json(), 
        (error) => console.error(error) 
        ).then(
            dataJson => functionCallback(dataJson), 
            erro => console.error(erro) 
            ); 
}

