import './App.css';
import PersonalDetailes from './Components/PersonalDetailsTable' 
import GetPersonalDetailes from './Components/GetPersonalDetailes';
import InputDetails from './Components/AddPerson';
import Graph from './Components/GraphComponent'
function App() {
  return (
    <div className="App">
      
      <GetPersonalDetailes/>
      <InputDetails/>
      <Graph/>
      
    </div>
  );
}

export default App;
