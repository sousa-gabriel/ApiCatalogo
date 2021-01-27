import React, { Component } from 'react';

export class Home extends Component {
    static displayName = Home.name;

        const response = await fetch('Produtos');
        const data = await response.json();
        console.log(data)
    

    return() {

      <div>
            <h1>Hello, world!</h1>
      
        </div>
    };
  }

