import React from "react";
import Header from "../Header/Header.js";
import "./Hero.css";
import { HiLocationMarker } from 'react-icons/hi';
import CountUp from "react-countup";

import Discover from "../discover/Discover.jsx";


const Hero = () => {
    return (
            {/* Partie Header */}
            <Header />

            <div className="hero">
                <div className="hero-text">
                    <h1>Welcome to Our Platform</h1>
                    <p>Your journey begins here.</p>
                </div>
            </div>
            <Discover />


        
    );
};

export default Hero;
