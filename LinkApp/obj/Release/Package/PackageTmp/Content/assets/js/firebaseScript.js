const firebaseConfig = {
    apiKey: "AIzaSyDNr3UXvgEry90YRCba1xuX7lmNWv1Za8I",
    authDomain: "trupic-feac9.firebaseapp.com",
    projectId: "trupic-feac9",
    storageBucket: "trupic-feac9.appspot.com",
    messagingSenderId: "122567455937",
    appId: "1:122567455937:web:41dc6fa4d446d5a7151040",
    measurementId: "G-BCDLNTXYFR"
};
// Initialize Firebase

firebase.initializeApp(firebaseConfig);
const db = firebase.firestore();
const dbref = firebase.database();
//const messaging = firebase.messaging();
const storageRef = firebase.storage();


function convertStampDate(unixtimestamp) {

    // Unixtimestamp

    // Months array
    var months_arr = ['January', 'February', 'March', 'April', 'May', 'June', 'July', 'August', 'September', 'October', 'November', 'December'];

    // Convert timestamp to milliseconds
    var date = new Date(unixtimestamp * 1000);

    // Year
    var year = date.getFullYear();

    // Month
    var month = months_arr[date.getMonth()];

    // Day
    var day = date.getDate();

    // Hours
    var hours = date.getHours();

    // Minutes
    var minutes = "0" + date.getMinutes();

    // Seconds
    var seconds = "0" + date.getSeconds();

    // Display date time in MM-dd-yyyy h:m:s
    //format
    var fulldate = month + ' ' + day + '-' + year + ' ' + hours + ':' + minutes.substr(-2) + ':' + seconds.substr(-2);

    // filtered fate
    var convdataTime = month + ' ' + day + ' ' + year;
    return fulldate;
}

function getDate(unixtimestamp) {

    // Unixtimestamp

    // Months array
    var months_arr = ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul', 'Aug', 'Sep', 'Oct', 'Nov', 'Dec'];

    // Convert timestamp to milliseconds
    var date = new Date(unixtimestamp * 1000);

    // Year
    var year = date.getFullYear();

    // Month
    var month = months_arr[date.getMonth()];

    // Day
    var day = date.getDate();

    // Hours
    var hours = date.getHours();

    // Minutes
    var minutes = "0" + date.getMinutes();

    // Seconds
    var seconds = "0" + date.getSeconds();

    // Display date time in MM-dd h:m:s
    format
    var fulldate = month + ' ' + day + ',' + hours + ':' + minutes.substr(-2);

    // filtered fate
    var convdataTime = month + ' ' + day + ' ' + year;
    return fulldate;
}