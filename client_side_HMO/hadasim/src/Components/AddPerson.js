import React from 'react'
import axios from 'axios'
import { useState,useRef, useEffect } from 'react'
import PersonalDetailes from './PersonalDetailsTable'
import "./Table.css"
import FileUploadComponent from './UploadImage'

function is_israeli_id_number(id) {
	id = String(id).trim();
	if (id.length > 9 || isNaN(id)) return false;
	id = id.length < 9 ? ("00000000" + id).slice(-9) : id;
		return Array.from(id, Number).reduce((counter, digit, i) => {
			const step = digit * ((i % 2) + 1);
			return counter + (step > 9 ? step - 9 : step);
		}) % 10 === 0;
}
function validateTelephonNumber(phoneNumber) {
    const regex = /^0?(([23489]{1}\\D{7})|[5]{1}[012345689]\\D{7})$/;
    return regex.test(phoneNumber);
}


function validatePhoneNumber(phoneNumber) {
    const regex = /^[0][5][0|2|3|4|5|9]{0,1}[0-9]{7}$/;
    return regex.test(phoneNumber);
}


export default function InputDetails()
{
    const [dataToSet, setData] = useState(null)
    const [id, setId] = useState(null)
    const [name, setName] = useState(null)
    const [city, setCity] = useState(null)
    const [street, setStreet] = useState(null)
    const [house, setHouse] = useState(null)
    const [telephon, setTelephon] = useState(null)
    const [pelephon, setPelephon] = useState(null)
    const [ill, setIll] = useState(null)
    const [healthy, setHealthy] = useState()
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
    const handleInputChangeCity = (event) => {
        setCity(event.target.value);
    }
    const handleInputChangeVaccination = (event) => {
        setVaccination(event.target.value);
    }
    const  [selectedFile, setSelectedFile] = useState('');
    const selectFileHandler = (event)=>{
        //1. define the array for the file type e.g. png, jpeg
        const fileTypes = ['image/png', 'image/jpeg'];
 
        // 2. get the file type
         let file = event.target.files;
         console.log(`File ${file}`);
        // 3. the message for error if the file type of not matched
        let errMessage = [];
        // 4. to check the file type to match with the fileTypes array iterate 
        // through the types array
        if(fileTypes.every(extension=> file[0].type !=extension)){
            errMessage.push(`The file ${file.type} extension is not supported`);
        } else {
            setSelectedFile(file[0]);
        }
     };
    const handleInputChangeData = (e) =>
    {
        if(!is_israeli_id_number(id))
        {
            alert("The ID number is invalid")
            return;
        }
        if(validateTelephonNumber(telephon))
        {
            alert("The Telephon number is invalid")
            return;
        }
        if(validatePhoneNumber(pelephon))
        {
            alert("The Pelephon number is invalid")
            return;
        }
        if(vaccination_number > 4 || vaccination_number < 0)
        {
            alert("The vaccination number is invalid")
            return;
        }
        const ill1 = new Date(ill);
        const healthy1 = new Date(healthy);
        if(ill1.getTime() > healthy1.getTime())
        {
            alert("Did you recover before you got sick?! \n Fix it!")
            return;
        }
        
        
        let obj = {
            "id": id,
            "name": name,
            "city": city,
            "street": street,
            "house_number": house,
            "telephon": telephon,
            "pelephon": pelephon,
            "vaccination_number": vaccination_number,
            "start_ill": ill,
            "end_ill": healthy,
            "imageUrl": "Hello",
          }
        setData(obj);
        uploadHandler();
        
    }
    const uploadHandler = () => {
        // 1. the FormData object that contains the data to be posted to the 
        // WEB API
        const formData = new FormData();
        formData.append('file', selectedFile);
        
        // 2. post the file to the WEB API
        axios.post("https://localhost:7236/api/Values/"+id, formData)
      .then((response) => { 
        this.setState({status:`upload success ${response.data}`});
      })
      .catch((error) => { 
        this.setState({status:`upload failed ${error}`});
      })
    }

    return(
        <div className="inputDiv">
            <h1 >Add person</h1><br/><br/>
            <form>
                <span>Set your ID number</span><br/><br/>
                <input className='input' id="id" type="text"  onChange={handleInputChangeId}></input><br/><br/>
                <span>Set your full name</span><br/><br/>
                <input className='input' id="name" type="text" onChange={handleInputChangeName}></input><br/><br/>
                <span>Set your City</span><br/><br/>
                <input className='input' id="city" type="text"  onChange={handleInputChangeCity}></input><br/><br/>
                <span>Set your street</span><br/><br/>
                <input className='input' id="street" type="text" onChange={handleInputChangeStreet}></input><br/><br/>
                <span>Set your house number</span><br/><br/>
                <input className='input' id="house" type="number" onChange={handleInputChangeHouse}></input><br/><br/>
                <span>Set your telephon</span><br/><br/>
                <input className='input' id="telephon" type="text" onChange={handleInputChangeTelephon}></input><br/><br/>
                <span>Set your pelephon</span><br/><br/>
                <input className='input' id="pelephon" type="text" onChange={handleInputChangePelephon}></input><br/><br/>
                <span>Set the number of vaccinations you have had </span><br/><br/>
                <input className='input' id="vaccination_number" type="number" defaultValue={0} onChange={handleInputChangeVaccination}></input><br/><br/>
                <span>Set your date that you was ill</span><br/><br/>
                <input className='input' id="ill" type="date" onChange={handleInputChangeIll}></input><br/><br/>
                <span>Set your date that you was healthy</span><br/><br/>
                <input className='input' id="healthy" type="date" onChange={handleInputChangeHealthy}></input><br/><br/>
                <label>Select File to Upload</label><br/><br/>
                <input className='input' type="file" onChange={selectFileHandler}/><br/><br/>
                <input className='input buttom' type="submit" value="Upload" onClick={handleInputChangeData}/><br/>
                <Add data={dataToSet}/>
                <AddImage image={file} id ={id}/>
                
    

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
                
                }
    }).catch((error) => {
        console.log("error!!");
        alert("Error!!!");
        
    })
    console.log(props.data);
    

}
const AddImage = (props)=>{
    if(props.image == null)
    {
            return null
    }
    axios.post('https://localhost:7236/api/Values/' + props.id, props.image).then(
        (response) => {
            console.log(response);
            let data = response.data;
            if (data){
                alert("Image successfully added!");
                return(
                    <div>
                        Image successfully added
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


