function myFunction() {
    var x = Math.floor((Math.random() * 10) + 1);
    var greeting;
    if(x ==2){
        greeting = "Parabéns você ganhou cupom de 10% codigo: #desonto10";
    
    }
    else{
        greeting = " Infelizmente não foi desta vez, quer tentar novamente preencha os campos"
    }
    document.getElementById("demo").innerHTML = greeting;
     
}