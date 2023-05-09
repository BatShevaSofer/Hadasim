import React from 'react'
import axios from 'axios'
import { useState, useEffect } from 'react'
import PersonalDetailes from './PersonalDetailsTable'

export default function GetPersonalDetailes(){
    const [getP, setGet] = useState(null)

    useEffect(()=>{
        axios.get("https://localhost:7236/api/PersonalDetailes").then((response)=>
        {

            setGet(response.data)
            console.log(response);
        }).catch((err)=>
        {
            return(<div>"error! error!" +err.massage;</div>)
        })
    }, [])

    if(!getP) return null

    return(
        <div>
            <PersonalDetailes data={getP}/>
        </div>
    )
}