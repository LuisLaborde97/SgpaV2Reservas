const URL = 'https://localhost:7057/api/';

export function login(usuario, pass){
    let datos = {Usuario1:usuario, Password:pass};

    return fetch(URL+'Authentication',{
        method: 'POST',
        body: JSON.stringify(datos),
        headers: {
            'Content-Type': 'application/json'
        }
    })
    .then(response => response.text())
}

export function getReservas(usuario){
    return fetch(URL+'index?usuario='+usuario,{
        headers:{
            'Content-Type':'application/json'
        }
    })
    .then(data => data.json());
}