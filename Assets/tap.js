var kue1 : GameObject;
var kue1a : GameObject;
var scoreText : GameObject;
var livesText : GameObject;
var walkingSpeed : double;
var livesNumber : int;
var score2Number : int;


function Start () {
    kue1 = GameObject.Find("kue1");
    kue1a = GameObject.Find("kue1a");
       
    //Initialize the values of walking speed
    
    score2Number = 0;
    

    //Place the ant in a random position on start of the game
    kue1.transform.position.x = generateX();
    kue1.transform.position.y = generateY();
}

function Update () {	

    if(kue1.transform.position.y < -4.35){	
		
        kue1.transform.position.x = generateX();
        kue1.transform.position.y = generateY();   
        
    }else if(livesNumber > 0 && kue1a == kue1){	
       nila();

        
      }else{

        kue1.transform.position.y -= walkingSpeed;
    }
}

function gameOver(){	
    Application.LoadLevel("awal");
}


//Generates random x
function generateX(){
    var x = Random.Range(-2.54,2.54);
    return x;
}

//Generates random y
function generateY(){
    var y = Random.Range(-4.0,3.8);
    return y;
}

//Move the "Ant" to the new coordiantess
function generateCoordinates(){
   
    Destroy(GameObject.Find("kue1a"));
    kue1.transform.position.x = generateX();
    kue1.transform.position.y = generateY();
}
function nila(){
    //You clicked it!
    score2Number += 2;
    generateCoordinates();
}

//If tapped or clicked
function OnMouseDown(){
    //Place the ant at another point
    generateCoordinates();

    //Increase the walking speed by 0.01
    walkingSpeed += 0.01;
}