var kue : GameObject;
var kue1a : GameObject;
var scoreText : GameObject;
var livesText : GameObject;
var walkingSpeed : double;
var livesNumber : int;
var score1Number : int;


function Start () {
    kue = GameObject.Find("kue");
    kue1a = GameObject.Find("kue1a");
    score1Number = 0;
    
    //Place the ant in a random position on start of the game
    kue.transform.position.x = generateX();
    kue.transform.position.y = generateY();
}

function Update () {	

     if(livesNumber > 0 && kue1a == kue){	
        Nilai();


    }else{

        kue.transform.position.y -= walkingSpeed;
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
    kue.transform.position.x = generateX();
    kue.transform.position.y = generateY();
}
function Nilai(){
    //You clicked it!
    score1Number += 1;
    generateCoordinates();

}
//If tapped or clicked
function OnMouseDown(){
    //Place the ant at another point
    generateCoordinates();

    //Increase the walking speed by 0.01
    walkingSpeed += 0.01;
}