import React from 'react';
import styles from './styles.css'
import closed from '../images/closed_card.png'
import id1 from '../images/opened_card_1.png'
import id2 from '../images/opened_card_2.png'
import id3 from '../images/opened_card_3.png'
import id4 from '../images/opened_card_4.png'
import id5 from '../images/opened_card_5.png'
import id6 from '../images/opened_card_6.png'
import id7 from '../images/opened_card_7.png'
import id8 from '../images/opened_card_8.png'
import id9 from '../images/opened_card_9.png'
import id10 from '../images/opened_card_10.png'
import id11 from '../images/opened_card_11.png'
import id12 from '../images/opened_card_12.png'
import id13 from '../images/opened_card_13.png'
import id14 from '../images/opened_card_14.png'
import id15 from '../images/opened_card_15.png'
import id16 from '../images/opened_card_16.png'

export default class Field extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            face: this.getClosed,
            id: props.id,
        }
    }

    render() {
        return (
            this.state.face()
        );
    }

    getClosed = () => <div className={styles.root} onClick={this.openClose}>
        <img src={closed} width={"140px"} height={"140px"}/>
    </div>;
    
    openClose = (previos) => true;
}
