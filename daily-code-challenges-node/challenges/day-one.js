//Libraries are included up here
const _ = require('lodash');
const readLine = require('readline');
const Promise = require('bluebird');
//Setting the interface for I/O
const r1 = readLine.createInterface({
    input: process.stdin,
    output: process.stdout
});

//Challenge Methods - Challenge 1

exports.challenge_no = ()=> "Day One Challenge";

exports.run = function(){
    let items = [10, 15, 3, 7];
    return new Promise((resolve,reject)=>{
        r1.question('Input: ', input=>{
            input = 17;//parseInt(input);

            console.log('Array: [' + items + ']');
            console.log('Input: ' + input);
            /*
                Loop through an Array of Numbers. Based on User Input, check to see if any two integers add up to USER_INPUT
            * */
            for(let ind = 0; ind < items.length; ind++){
                if(_.some(items,function(item, i){
                    //Skip the same index of the array
                    if(i === ind) return false;
                    return items[ind] + item === input;
                })){
                    resolve(true);
                }
            }
            resolve(false);
        });
    });

};

