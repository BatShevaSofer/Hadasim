import React from 'react'
import axios from 'axios'
import { useState,useRef, useEffect } from 'react'
import PersonalDetailes from './PersonalDetailsTable'
import "./Table.css"



export default function InputDetails()
{
    const [dataToSet, setData] = useState(null)
    const [id, setId] = useState("Set your ID number")
    const [name, setName] = useState("Set your full name")
    const [street, setStreet] = useState("Set your street")
    const [house, setHouse] = useState("Set your house number")
    const [telephon, setTelephon] = useState("Set your telephon")
    const [pelephon, setPelephon] = useState("Set your pelephon")
    const [ill, setIll] = useState("Set your date that you was ill")
    const [healthy, setHealthy] = useState("Set your date that you was healthy")
    const [file, setFile] = useState(null)
    const [vaccination_number, setVaccination] = useState(null)
 
    const handleInputChangeId = (event) => {
        setId(event.target.value);
    }
    const handleInputChangeName = (event) => {
        setName(event.target.value);
    }
    const handleInputChangeStreet = (event) => {
        setStreet(event.target.value);
    }
    const handleInputChangeHouse = (event) => {
        setHouse(event.target.value);
    }
    const handleInputChangeTelephon = (event) => {
        setTelephon(event.target.value);
    }
    const handleInputChangePelephon = (event) => {
        setPelephon(event.target.value);
    }
    const handleInputChangeIll = (event) => {
        setIll(event.target.value);
    }
    const handleInputChangeHealthy = (event) => {
        setHealthy(event.target.value);
    }
    const handleInputChangeFile = (e) => {
        
        //console.log(e);
        //const file = e.target.files[0];
        //console.log(file.name); // הצגת שם הקובץ
        //console.log(URL.createObjectURL(file)); // הצגת הניתוב המלא של התמונה
        //setFile(e.target.files[0]) ;
        //console.log(file.webkitRelativePath);
    }
    const handleInputChangeVaccination = (event) => {
        setVaccination(event.target.value);
    }
    const handleInputChangeData = (e) =>
    {
        let obj = {
            "id": id,
            "name": name,
            "city": {
              "id": 0,
              "city_name": "string"
            },
            "street": street,
            "house_number": house,
            "telephon": telephon,
            "pelephon": pelephon,
            "vaccination_number": vaccination_number,
            "start_ill": ill,
            "end_ill": healthy,
            "imageUrl": "I/Dont/Succsses!"
          }
        setData(obj)
    }

    return(
        <div className="inputDiv">
            <h1 >Add person</h1><br/><br/>
            <form>
                <input className='input' id="id" type="text" defaultValue={id} onChange={handleInputChangeId}></input><br/><br/>
                <input className='input' id="name" type="text" defaultValue={name} onChange={handleInputChangeName}></input><br/><br/>
                <span>city</span><br/><br/>
                <input className='input' id="street" type="text" defaultValue={street} onChange={handleInputChangeStreet}></input><br/><br/>
                <input className='input' id="house" type="number" defaultValue={house} onChange={handleInputChangeHouse}></input><br/><br/>
                <input className='input' id="telephon" type="text" defaultValue={telephon} onChange={handleInputChangeTelephon}></input><br/><br/>
                <input className='input' id="pelephon" type="text" defaultValue={pelephon} onChange={handleInputChangePelephon}></input><br/><br/>
                <input className='input' id="vaccination_number" type="number" defaultValue={0} onChange={handleInputChangeVaccination}></input><br/><br/>
                <input className='input' id="ill" type="date" defaultValue={ill} onChange={handleInputChangeIll}></input><br/><br/>
                <input className='input' id="healthy" type="date" defaultValue={healthy} onChange={handleInputChangeHealthy}></input><br/><br/>
                <input className='input' id="file" type="url" accept="image/*" ref={file} onChange={handleInputChangeFile}/><br/>
                <input className='input' type="submit" value="Upload" onClick={handleInputChangeData}/><br/>
                <Add data={dataToSet}/>

            </form>
            
        </div>
    )

}

const Add=(props)=>{
    const [post, setPost] = useState(null)
    if(props.data == null)
    {
            return null
    }
       
    axios.post('https://localhost:7236/api/PersonalDetailes', props.data).then(
        (response) => {
            console.log(response);
            let data = response.data;
            if (data){
                alert("User successfully added!");
                return(
                    <div>
                        User successfully added
                    </div>
                );}
            else{
                alert("Error1!!!");
                return(
                    <div>
                        Error1!!!
                    </div>
                );}
    }).catch((error) => {
        console.log("error!!");
        alert("Error!!!");
        return(
            <div>
                Error!!!
            </div>
        );
    })
    console.log(props.data);
    

}


