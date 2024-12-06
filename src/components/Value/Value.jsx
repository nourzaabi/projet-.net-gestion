import React from 'react'
import {
    Accordion,
    AccordionItem,
    AccordionItemHeading,
    AccordionItemButton,
    AccordionItemPanel,
    AccordionItemState

} from 'react-accessible-accordion'

import { MdOutlineArrowDropDown } from 'react-icons/md'
import './Value.css'
const Value = () => {
    return (
        <section className="v-wrapper">
            <div className="paddings innerWidth flexCenter v-container">
                {/*leftside*/}
                <div className="v-left">
                    <div className="image-container">
                        <img src=".value.png" alt="" />

                    </div>

                </div>

            </div>

        </section>
    )

}
export default Value