import { useState } from 'react'
import 'bootstrap/dist/css/bootstrap.css'

function App() {
  const [count, setCount] = useState(0)
  const [disabled, setDisabled] = useState(true)
  const [website, setWebsite] = useState('')
  const [login, setLogin] = useState('')
  const [password, setPassword] = useState('')
  const [submitted, setSubmitted] = useState(false)

  return (
    <>
      <div id="block1">
        <h1>Menedżer haseł - wykonał: 18</h1>
        <form>
          <label htmlFor="website">Adres WWW: </label>
          <input type="text" id="website" name="website" className="form-control" placeholder="Adres strony WWW" onChange={(e) => {setWebsite(e.target.value)}} />
          <label htmlFor="login">Login: </label>
          <input type="text" id="login" name="login" className="form-control" placeholder="Twój login" onChange={(e) => {setLogin(e.target.value)}} />
          <input type="checkbox" id="cb" name="cb" onChange={()=>setDisabled(!disabled)} checked={disabled}/>
          <label htmlFor="cb"> Wygeneruj hasło</label>
          <br />

          {!disabled && <>
            <label htmlFor="password">Hasło: </label>
            <input type="password" id="password" name="password" className="form-control" onChange={(e) => {setPassword(e.target.value)}} />
          </>}
          {disabled && <>
            <label htmlFor="password">Hasło: </label>
            <input type="password" id="password" name="password" className="form-control" disabled={true} />
          </>}
          <button type="button" className="btn btn-primary" onClick={()=>{setSubmitted(true)}}>Zapisz</button>
        </form>
      </div>
      {submitted && <>
        <div id="block2">
          <p className="p-2" style={{color: "blue", fontSize: "130%"}}>Adres: {website}</p>
          <p className="p-2">Login: {login}</p>
          {disabled && <>
            <p className="p-2">Hasło generowane automatycznie</p>
          </>}
          {!disabled && <>
            <p className="p-2">Hasło: {password}</p>
          </>}
        </div>
      </>}

    </>
  )
}

export default App
