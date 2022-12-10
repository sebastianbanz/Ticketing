

function Header() {
    return (
        <div className="home-header" id="header">
            
            <h1>hello</h1>
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