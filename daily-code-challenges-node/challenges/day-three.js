const Promise = require('bluebird');

exports.challenge_no = ()=> "Day Three Challenge";

exports.run = function(){
    //Input: [] of Integers
    //Output: Product of all except @ i
    let req = [5,2,3,4];
    return new Promise((resolve,reject)=>{
        let result = [];
        for(let ind = 0; ind < req.length; ind++){
            let total = 1;
            for(let prodInd = 0; prodInd < req.length; prodInd++){
                if( prodInd !== ind){

                    total *= req[prodInd];
                }
            }
            result.push(total);
        }
        resolve(result);
    });
};
