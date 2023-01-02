
import React, { useEffect, useState } from "react"

function Header() {
    return (
        <div className="home-header" id="header">
            
          

          <h1>Hello</h1>

       
           
        </div>
      
    );
}

const HomeContent = () => {
    const [individual, setIndividual] = useState([]);

    useEffect(() => {
        fetch('https://localhost:44478/Individual/2')
            .then((res) => res.json())
            .then((data) => {
                console.log(data);
                setIndividual(data[0]);
            })
            .catch((err) => {
                console.log(err.message);
            });
    }, []);

    return (
        <div>
            <h3>{individual.fname}</h3>
        </div>
   );
};
 
   

export default function Home()
{
    return (
        <div>

            <Header/>
            <HomeContent />
            
        </div>
        

    );


}