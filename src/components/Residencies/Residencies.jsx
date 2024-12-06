import React from 'react';
import { Swiper, SwiperSlide, useSwiper } from 'swiper/react'; // Assurez-vous d'importer useSwiper
import "swiper/css";
import './Residencies.css';
import data from '../../utils/slider.json';
import { sliderSettings } from "../../utils/common";

const Residencies = () => {
    return (
        <section className="r-wrapper">
            <div className="paddings innerWidth r-container">
                <br /><div className="r-head flexColStart">
                    <span className="orangeText">Best Choices</span><br/>
                    <span className="primaryText">Popular Residencies</span><br /><br />
                </div>


                <Swiper {...sliderSettings}>

                    {/* Boutons Slider */}

                    <SliderButtons />
                    {
                        data.map((card, index) => (
                            <SwiperSlide key={index}>
                                <div className="flexColStart r-card">
                                    <img src={card.image} alt="home" />
                                    <span className="secondaryText r-price">
                                        <span style={{ color: "white" }}>DT</span>
                                        <span>{card.price}</span>
                                    </span>
                                    <span className="primaryText">{card.name}</span>
                                    <span className="secondaryText">{card.detail}</span>
                                </div>
                            </SwiperSlide>
                        ))
                    }
                </Swiper>
            </div>
        </section>
    );
};

export default Residencies;

// Boutons de navigation


const SliderButtons = () => {
    const swiper = useSwiper(); // Utilisez correctement useSwiper
    return (
        <div className="flexCenter r-button">
            <button onClick={() => swiper.slidePrev()}>&lt;</button>
            <button onClick={() => swiper.slideNext()}>&gt;</button>
        </div>
    );
};
