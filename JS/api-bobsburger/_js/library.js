const URL_API_CHARACTER = 'https://bobsburgers-api.herokuapp.com/characters/?limit=15'

function getElement(q) {
    return document.querySelector(q);
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

