const Promise = require('bluebird');

exports.challenge_no = ()=> "Day Two Challenge";

exports.run = function(){
    //FIZZ BUZZ
    //multiple of 3's print fizz
    //multiples of 5's print buzz
    //multiples of 3's & 5's print fizzbuzz
    return new Promise((resolve,reject)=>{
        let seq = '';
        for(let x = 1; x <= 100; x++){
            if(x % 3 === 0 && x % 5 === 0){
                seq += 'FizzBuzz';
            }else if(x % 3 === 0){
                seq += 'Fizz';
            }else if(x % 5 === 0){
                seq += 'Buzz';
            }else{
                seq += x;
            }
            if(x !== 100){
                seq += ',';
            }
        }
        resolve(seq);
    });
};
