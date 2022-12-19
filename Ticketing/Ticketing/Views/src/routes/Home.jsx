
import React, { useState, useEffect } from 'react';

function Header() {

    return (
        <div className="home-header" id="header">
            
           <body> 
              

          <h1>Hello</h1>

            </body>
         
           
        </div>
      
    );
}

async function HomeContent()
{
    const [name, setName] = useState([]);

    useEffect(() => {getNames()})

    const getNames = async () => {

        const response = await fetch('https://localhost:44478/Individual/1');
        setName(await response.json());
    }



    return (

        <div>

            {name.map((data) => {
                return (
                    <h3 key={data.id}> {data.fname} </h3>
                )
            })}

        </div>

    )
 
}

export default function Home()
{
    return (
        <div>

            <Header/>
            <HomeContent />
            
        </div>
        

    );


}