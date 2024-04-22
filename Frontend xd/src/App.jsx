
import { Routes, Route } from "react-router-dom"
import { Login } from './Login'
import { Dashboard } from "./Dashboard"
import { NuevaReserva } from "./NuevaReserva"

function App() {

    return(
        <Routes>
            <Route path="/" element={<Login />} />
            <Route path='/dashboard' element={<Dashboard/>}/>
            <Route path="/reserva" element={<NuevaReserva/>}/>
        </Routes>
    )
}

export default App