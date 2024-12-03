import React from "react";
import "./Hero.css"
import {HiLocationMarker} from 'react-icons/hi';

const Hero = () => {
    return(
        <section className="hero-wrapper">

            <div className="paddings innerWidth flexCenter hero-container ">

                <div className="flexColStart hero-left">

                    <div className="hero-title">
                    
                        <h1>Discover <br /> Most Suitable <br />Property</h1>



            </div>
            <div className="flexColStart hero-des">
                <span> Find a variety of propreties that suit you very easilty</span>
                <span>Forgot all difficulties in finding a residence for you </span>



            </div>
            <div className="search-bar">
                    <HiLocationMarker color="var(--blue)" size={25}/>
                    <input type="text" / >
                    <button className="button">Search</button>


            </div>

        </div>
            <div className="flexCenter hero-right">
                <div className="image-container">
                    <img src="./hero-image.png" alt="" />
                </div>
            </div>



            </div>

        </section>
    )



}
export default Hero ;