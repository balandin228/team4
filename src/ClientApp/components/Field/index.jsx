import React from 'react';
import styles from './styles.css'
import test from '../images/1.jpg'

export default class Field extends React.Component {
    render (props) {
        return (
            <div className={ styles.root }>
                <img src={test} width={"140px"} height={"140px"}/>
            </div>
        );
    }
}
