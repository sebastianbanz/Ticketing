
import { exampleFunction } from "../ViewControllers/home"


function Header() {

    

    return (
        <div className="home-header" id="header">
            
           <body> 
              

          <h1>Hello</h1>

            </body>
         
           
        </div>
      
    );
}

function HomeContent()
{
    return (
         
        <div>

            <h3> This website is made using:</h3>
            <h3> React </h3>
                <h3>   C#</h3>
                    <h3>  and javascript </h3>
                    <button onClick={exampleFunction}>hi</button>
        </div>

    )
    
}

export default function Home()
{
    return (
        <div>

            <Header />
            <HomeContent />
            
        </div>
        

    );


}