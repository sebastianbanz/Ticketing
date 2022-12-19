

export async function exampleFunction() {

    fetch('https://localhost:44478/Individual')
        .then((response) => response.json())
        .then((data) => console.log(data));
    
}