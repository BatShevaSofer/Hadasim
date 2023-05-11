import './App.css';
import PersonalDetailes from './Components/PersonalDetailsTable' 
import GetPersonalDetailes from './Components/GetPersonalDetailes';
import InputDetails from './Components/AddPerson';
import FileUploadComponent from './Components/UploadImage';
import { useState } from 'react';
import { Routes, Route, Link } from 'react-router-dom';
import BarCart from './Components/BarChartComponenet';
import LineCart from './Components/LineChartComponent';
import Graph from './Components/GraphComponent';
//const days1 = [1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31]

function App() {

  return (
    <div className="App">
    <div>
        <nav>
          <ul>
            <li>
              <Link to="/">Personal Detailes Table</Link>
            </li>
            <li>
              <Link to="/graph">Graph</Link>
            </li>
            <li>
              <Link to="/add_person">Add Person</Link>
            </li>
            
          </ul>
        </nav>

        <Routes>
          <Route path="/" element={<GetPersonalDetailes />} />
          <Route path="/graph" element={<Graph />} />
          <Route path="/add_person" element={<InputDetails />} />
        </Routes>
      </div>
    </div>
  );
}

export default App;
