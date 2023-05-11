import {Bar} from "react-chartjs-2"
import React from 'react'
import {Chart as ChartJS} from 'chart.js/auto'




function BarCart({props}){
    return( <Bar data={props} />)
}



export default BarCart;