import { useState, useEffect } from "react"
import * as API from "./services/data"

export function ListReservas(){
    let usuario = sessionStorage.getItem("usuario");
    const [Reserva, setReservas] = useState([])
    useEffect(() => {
        API.getReservas(usuario).then(setReservas);
    })
    return(
        <>
            <table>
                <thead>
                    <tr>
                        <th>ID</th>
                        <th>Usuario que Realizo la Reserva</th>
                        <th>Descripcion de la Reserva</th>
                        <th>Precio de la Reserva</th>
                        <th>Fecha en que se Realizo la Reserva</th>
                        <th></th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
                    {
                        Reserva?.map(reserva => (
                            <tr key={reserva.id}>
                                <td>{reserva.id}</td>
                                <td>{reserva.nombreUsuario}</td>
                                <td>{reserva.descripcion}</td>
                                <td>{reserva.precio}</td>
                                <td>{reserva.fecha}</td>
                                <td>Editar</td>
                                <td>Eliminar</td>
                            </tr>
                        ))
                    }
                </tbody>
            </table>
        </>
    )
}