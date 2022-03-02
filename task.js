let fName = document.querySelector("#firstname");
let lName = document.querySelector("#lastname");
let email = document.querySelector("#emailid");
let contact = document.querySelector("#contactno");
let city = document.querySelector("#ddlcity");
let gender = document.querySelector('input[name="gender"]');

let userData = [];
let dataRow="";
let initData = "<table border='1'><tr><th>First Name</th><th>Last Name</th><th>Email</th><th>Contact No.</th><th>City</th><th>Gender</th></tr>"
let tailData = "</table>"; 

const register = function (event) {
        let currentUser = {
                firstName: '',
                lastName:'',
                email:'',
                contact:'',
                city:'',
                gender:''
        };
        // Receive user input
        currentUser.firstName = fName.value;
        currentUser.lastName = lName.value;
        currentUser.email = email.value;
        currentUser.contact = contact.value;
        currentUser.city = city.value;
        currentUser.gender = gender.value;

        userData.push(currentUser);

        const myForm = document.querySelector('#infoForm').reset(); 
        setData(userData);
};

let setData = function(data){
        dataRow = "";
        data.forEach((item,index)=>{
                dataRow+="<tr id = '"+index+"' name = 'row'><td>"+item.firstName+"</td>";
                dataRow+="<td>"+item.lastName+"</td>";
                dataRow+="<td>"+item.email+"</td>";
                dataRow+="<td>"+item.contact+"</td>";
                dataRow+="<td>"+item.city+"</td>";
                dataRow+="<td>"+item.gender+"</td></tr>";
        });
        document.querySelector('#data').innerHTML = initData + dataRow + tailData;
}