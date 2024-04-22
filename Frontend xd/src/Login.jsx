import { useState } from 'react';
import * as API from './services/data';
import { useNavigate } from 'react-router-dom';

export function Login() {
    const [Usuario, setUsuario] = useState({usuario:'',password:''});
    const navigate = useNavigate();

    async function handleSubmit(e){
      e.preventDefault();
      const response = await API.login(Usuario.usuario, Usuario.password);
      if (response.length != 0) {
        sessionStorage.setItem("usuario", response)
        navigate("/dashboard")
      }else{
        alert("Error");
      }
    }
    return (
      <>
        <h1>Iniciar Sesion</h1>
        <form id='formulario' onSubmit={handleSubmit}>
          Usuario<input type="text" id="usuario" onChange={event => setUsuario({...Usuario, usuario:event.target.value})} /><br />
          Password<input type="password" id="password" onChange={event => setUsuario({...Usuario, password:event.target.value})} /><br />
          <input type="submit" value="Enviar" id='enviar'/>
        </form>
      </>
    )
}
  