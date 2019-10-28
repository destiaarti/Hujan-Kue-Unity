var kue : GameObject;
var kue1 : GameObject;
var kue2 : GameObject;
var walkingSpeed : double;



function Start () {
    kue = GameObject.Find("kue");
    kue1 = GameObject.Find("kue1");
    kue2 = GameObject.Find("kue2"); 
   
    //Initialize the values of walking speed
    walkingSpeed = 0.02;
    



	//Place the ant in a random position on start of the game
	kue.transform.position.x = generateX();
	kue.transform.position.y = generateY();
	kue1.transform.position.x = generateX();
	kue1.transform.position.y = generateY();
	kue2.transform.position.x = generateX();
	kue2.transform.position.y = generateY();
	
}

function Update () {	
    if(kue.transform.position.y < -4.35){	
		
        kue.transform.position.x = generateX();
        kue.transform.position.y = generateY();   
        
    }
    else if(kue1.transform.position.y < -4.35){	
		
        kue1.transform.position.x = generateX();
        kue1.transform.position.y = generateY();   
        
    }
    if(kue2.transform.position.y < -4.35){	
		
        kue2.transform.position.x = generateX();
        kue2.transform.position.y = generateY();   
        
    }
    else{
        kue.transform.position.y -= walkingSpeed;
        kue1.transform.position.y -= walkingSpeed;
        kue2.transform.position.y -= walkingSpeed;
    }

}



//Generates random x
function generateX(){
	var x = Random.Range(-2.54,2.54);
	return x;
}

//Generates random y
function generateY(){
    var y = Random.Range(-4.0,3.8);
    return y;}
    //Generates random x


//Move the "Ant" to the new coordiantess
