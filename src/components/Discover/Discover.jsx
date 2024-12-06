// src/components/discover/Discover.jsx
import React from "react";
import { HiLocationMarker } from 'react-icons/hi';
import CountUp from "react-countup";
import "./Discover.css";

const Discover = () => {
    return (
        <section className="discover-wrapper">
            <div className="paddings innerWidth flexCenter hero-container">

                <div className="flexColStart hero-left">
                    <div className="hero-title">
                        <h1>Discover <br /> Most Suitable <br />Property</h1>
                    </div>
                    <br />

                    <br />
                    <div className="flexColStart hero-des">
                        <span>Find a variety of properties that suit you very easily</span>
                        <span>Forget all difficulties in finding a residence for you</span>
                    </div>
                    <br />

                    <div className="search-bar">
                        <HiLocationMarker color="var(--blue)" size={25} />
                        <input type="text" />
                        <button className="button">Search</button>
                    </div>

                    <div className="flexCenter stats">
                        <div className="stat">
                            <span>
                                <CountUp start={8800} end={9000} duration={4} />
                                <span>+</span>
                            </span>
                            <span className="secondaryText">Premium Products</span>
                        </div>
                        <div className="stat">
                            <span>
                                <CountUp start={2000} end={4000} duration={4} />
                                <span>+</span>
                            </span>
                            <span className="secondaryText">Happy Customers</span>
                        </div>
                    </div>
                </div>

                <div className="flexCenter hero-right">
                    <div className="image-container">
                        <img src="./hero-image.png" alt="Right Section" />
                    </div>
                </div>

            </div>
        </section>
    );
};

export default Discover;
