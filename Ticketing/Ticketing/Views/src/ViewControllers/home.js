

export async function exampleFunction() {

        let response = await fetch('https://localhost:44478/Individual/1');
        let data = await response.json();
    console.log(data.id, data.fname)
    return (
        data
    );
}


