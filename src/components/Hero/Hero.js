import React from "react";
import Header from "../Header/Header.js";
import './Hero.css';

const Hero = () => {
    return (
        <>
            <Header />
            <div className="hero">
                <div className="hero-text">
                    <h1>Welcome to Our Platform</h1>
                    <p>Your journey begins here.</p>
                </div>
            </div>

        </>
    );
};

export default Hero;
