
import { getUser } from '../ViewControllers/home.ts' 
import React, { useEffect, useState } from "react"

function Header() {

    return (
        <div className="home-header" id="header">
            
          

          <h1>Hello</h1>

       
           
        </div>
      
    );
}

const HomeContent = () => {
    const [posts, setPosts] = useState([]);

    useEffect(() => {
        fetch('https://localhost:44478/Individual/1')
            .then((res) => res.json())
            .then((data) => {
                console.log(data);
                setPosts(data);
            })
            .catch((err) => {
                console.log(err.message);
            });
    }, []);

    return (
        <div>
            {posts.fname}
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