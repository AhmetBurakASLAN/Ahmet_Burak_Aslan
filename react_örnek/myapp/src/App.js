import logo from './logo.svg';
import './App.css'
import Header from './Components/Header';
import { Route, Routes } from 'react-router-dom';
import Home from './Pages/Home';


function App() {
  return (
    <div >
   <Header></Header>
   <Routes>
     <Route path='/' element={<Home/>}>
       
     </Route>
   </Routes>

    </div>
  );
}

export default App;
