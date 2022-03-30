//REQUIRE
const tmi = require('tmi.js');

//CMD Color
var colors = ['\x1b[31m', '\x1b[32m', '\x1b[33m', '\x1b[34m', '\x1b[35m', '\x1b[36m'];
var i = 0;

//FUNZIONI
//Twitch Tmi Client
const client = new tmi.Client({
   connection:{
      secure: true,
      reconnect: true,
   },
	channels: [ '@TextToChange' ]
});

//Twitch Tmi Connection
client.connect();

//Twitch Tmi Message Received
client.on('message', (channel, tags, message, self) => {
   if((tags['display-name'] != "StreamElements") && (!message.startsWith("!"))){

      console.log(colors[i], `\n${tags['display-name']}:`, '\x1b[37m', `${message}`);

      i++;
      if(i>(colors.length-1)){
         i=0;
      }

   }
});

//CODE
console.log(`\nStart: ${new Date()}`);