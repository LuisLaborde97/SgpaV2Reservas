import { Link } from "react-router-dom";

export function Header(){
    return(
        <>
            <p>
                <Link to={"/dashboard"}>Listado de Reservas</Link>
                <Link to={"/reserva"}>Crear Nueva Reserva</Link>


                <span>Cerrar Sesion</span>
            </p>
        </>
    )
}