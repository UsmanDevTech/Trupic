importScripts('https://www.gstatic.com/firebasejs/8.2.10/firebase-app.js');
importScripts('https://www.gstatic.com/firebasejs/8.6.2/firebase-messaging.js');

// Initialize the Firebase app in the service worker by passing in
// your app's Firebase config object.
// https://firebase.google.com/docs/web/setup#config-object

firebase.initializeApp({
    apiKey: "AIzaSyBhMJd2zznMsKIEi5GtP8NBwhhLqPSul8g",
    authDomain: "link-app-64c2d.firebaseapp.com",
    databaseURL: 'https://link-app-64c2d.firebaseio.com',
    projectId: "link-app-64c2d",
    storageBucket: "link-app-64c2d.appspot.com",
    messagingSenderId: "649543274356",
    appId: "1:649543274356:web:f1e62c56d84c1e06a6e621"
});

// Retrieve an instance of Firebase Messaging so that it can handle background
// messages.
const messaging = firebase.messaging();