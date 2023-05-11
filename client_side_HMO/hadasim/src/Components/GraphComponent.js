import React from "react";
import { useState  } from "react";

import LineCart from "./LineChartComponent";
import axios from 'axios'
async function GetPersonalDetailes() {
    try {
      const response = await axios.get("https://localhost:7236/api/PersonalDetailes");
      return response.data;
    } catch (err) {
      console.log(err);
      throw new Error("Failed to fetch personal details");
    }
  }

  function colNum(userData, days)
  {
      for(let i=0;i<userData.length;i++)
      {
          
          const start = Date(i.start_ill);
          const end = Date(i.end_ill);
          if(start.month != Date.now.month && end.month != Date.now.month)
              break;
          if(end.month == Date.now.month && start.month != Date.now.month)//קודם את הסוף ואח"כ את ההתחלה
          {
              start.month = Date.now.month;
              start.day = 1;
          }    
          while(end.month == Date.now.month && start <= end)
          {
              days[start.day+1] += 1;
              start.day += 1;
          }
      }
  }

function Graph()
{
    let days = new Array(31).fill(0);
    const userData  = GetPersonalDetailes();
    colNum(userData, days);
    const posts = days;
    const [userDataChart, setUaerDataChart] = useState({
      labels: days.map((data) => data),
      datasets: [{
        label:"Users sick",
        data: posts.map((data) => data.numIll),
      }]
    })
    return(
        <LineCart  props = {userDataChart} />
    )
}


export default Graph;