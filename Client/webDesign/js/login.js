

/* 
function GetUsers(){

const AllUsersAPIURL = "https:/localhost:5001/api/users";

fetch (AllUsersAPIURL).then(function(response){
    console.log(response);

    return response.json();

}).then(function(json){

    let html = "<ul>";

    json.forEach((book) => {

        html += "<li>" + user.id + " "+ book.title + " written by: " + book.author + "</li>"

    })




    html += "</ul>"


    document.getElementById("books").innerHTML=html; 
}).catch(function(error){
    console.log(error);
})
}


function postBooks(){
    const PostBooksApiURL = "https:/localhost:5001/api/books";
    const bookTitle = document.getElementById("title").value;
    const bookAuthor = document.getElementById("author").value;


    fetch(PostBooksApiURL, {
        method: "POST",

        headers:{
            "Accept" : 'application/json',
            "Content-Type" : 'application/json'
        },

        body:JSON.stringify({
            title: bookTitle,
            author: bookAuthor
        })
    })
.then((response)=>{
    console.log(response);
    getbooks();
})


}*/