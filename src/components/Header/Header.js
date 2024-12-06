import React, { useState, useEffect } from "react";
import './Header.css';

const Header = () => {
    const [isScrolled, setIsScrolled] = useState(false);

    useEffect(() => {
        const handleScroll = () => {
            if (window.scrollY > 50) {
                setIsScrolled(true);
            } else {
                setIsScrolled(false);
            }
        };

        window.addEventListener("scroll", handleScroll);

        return () => {
            window.removeEventListener("scroll", handleScroll);
        };
    }, []);

    return (
        <section className={`h-wrapper ${isScrolled ? "scrolled" : ""}`}>
            <div className="flexCenter paddings innerWidth h-container">
                <img src="./logo.png" alt="logo" width={100} />

                <div className="flexCenter h-menu">
                    <a href="">Residencies</a>
                    <a href="">Our Value</a>
                    <a href="">Contact Us</a>
                    <a href="">Get Started</a>
                    <button className="button">
                        <a href="">Contact</a>
                    </button>
                </div>
            </div>
        </section>
    );
};

export default Header;
