import { Header } from "./Header"
import { useState } from "react"

export function NuevaReserva(){

    const [NuevaReserva, setNuevaReserva] = useState({idRecurso:'', idUsuario:'', Estado:'', Fecha:''});

    function handleSubmit(e) {
        e.preventDefault();
    }

    return (
        <>
            <Header/>
            <p>Nueva Reserva</p>
            <form id="formulario" onSubmit={handleSubmit}>
                Recursos Disponibles 
                <select id="idRecurso">

                </select>
            </form>
        </>
    )
}