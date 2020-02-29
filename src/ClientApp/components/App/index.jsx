import React from 'react';
import styles from './styles.css';
import Field from '../Field';

export default class App extends React.Component {
    constructor() {
        super();
        this.state = {
            score: 50,
            picture: [[1, 2, 3, 4],
                [5, 6, 7, 8],
                [9, 10, 11, 12],
                [13, 14, 15, 16],
                [13, 14, 15, 16],
                [13, 14, 15, 16],
                [13, 14, 15, 16],
                [13, 14, 15, 16]]
        };
    }
    
    render() {
        return (
            <div className={styles.root}>
                <div className={styles.score}>
                    Ваш счет: {this.state.score}
                </div>
                <table className={styles.field}>
                    {this.getField()}
                </table>
            </div>
        );
    }
    
    getField(){
        const listItems = [];
        for (const number of [0, 1, 2, 3]) {
            let str = <tr>{this.state.picture.map((ob) => <td className="cell"><Field /></td>)}</tr>;
            listItems.push(str);
        }
        return listItems;
    }
}
