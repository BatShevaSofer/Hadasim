import React from 'react'
import { useState } from 'react';
import './Table.css'
import background from "./images/2.jpg"


const cities = [
    {name: "London", temperatura:"50f"},
    {name: "New York", temperatura:"72f"},
    {name: "San Francisco", temperatura:"55f"}
]

const Row = (props) => {
    const {id, name, city, street, house_number, telephon, pelephon, vaccination_number,start_ill, end_ill} = props
    const urlImg = "https://localhost:7236/api/Values/"
    return(
        <tr>
            <td className='text-left'>{id}</td>
            <td className='text-left'>{name}</td>
            <td className='text-left'>{city}</td>
            <td className='text-left'>{street}</td>
            <td className='text-left'>{house_number}</td>
            <td className='text-left'>{telephon}</td>
            <td className='text-left'>{pelephon}</td>
            <td className='text-left'>{vaccination_number}</td>
            <td className='text-left'>{start_ill}</td>
            <td className='text-left'>{end_ill}</td>
            <td className='text-left ' >
                <img src={urlImg + id} style={{width: '100%', height: 'auto'}}/>
            </td>
        </tr>
    )
}
const Table = (props) => {
    const {data} = props
    return(
        
            <tbody className='table-hover'>
                {data.map(row =>
                    <Row id = {row.id} 
                         name = {row.name} 
                         city = {row.city} 
                         street = {row.street}
                         house_number = {row.house_number}
                         telephon = {row.telephon}
                         pelephon = {row.pelephon}
                         vaccination_number = {row.vaccination_number}
                         start_ill = {row.start_ill}
                         end_ill = {row.end_ill} />)}
            </tbody>
     
    )
}

function PersonalDetailes(props)
{

    const [rows, setRows] = useState(props.data)

    return(
        <div>
            <div>
                <h1>Personal Details of HMO's clients</h1>
            </div>
            <table className='table-fill'>
                <thead>
                    <tr>
                        <th className="text-left">id</th>
                        <th className="text-left">name</th>
                        <th className="text-left">city</th>
                        <th className="text-left">street</th>
                        <th className="text-left">house_number</th>
                        <th className="text-left">telephon</th>
                        <th className="text-left">pelephon</th>
                        <th className="text-left">vaccination_number</th>
                        <th className="text-left">start_ill</th>
                        <th className="text-left">end_ill</th>
                        <th className="text-left" >image</th>

                    </tr>
                </thead>
                <Table data = { rows }/>
            </table>

        </div>
    )
}

export default PersonalDetailes;