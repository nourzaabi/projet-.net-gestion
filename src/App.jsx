import React from "react";
import Header from './components/Header/Header';
import Hero from "./components/Hero/Hero";
import Residencies from "./components/Residencies/Residencies";
import Companies from "./components/Companies/Companies";
import Discover from "./components/Discover/Discover";
import Value from "./components/Value/Value";
function App() {
  return (
    <div className="App">
      <Header />
          <Hero />
      <Discover />
      <Companies />
          <Residencies />
      <Value />
    </div>
  );
}


export default App;
