const glob = require('glob');
const Promise = require('bluebird');
glob('./challenges/**.js',function(er, files){
    return Promise.mapSeries(files, file=>{
        let challenge = require(file);
        console.log(`==========${challenge.challenge_no()}==========`);
        return challenge.run()
            .then((result)=>{
                console.log(result);
                return;
            });
    });
});





