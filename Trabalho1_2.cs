int lado_1 = Console.ReadLine();
int lado_2 = Console.ReadLine();
int lado_3 = Console.ReadLine();


<<<<<<< HEAD
//Alteração realizada por Carlos

//Outra alteração que foi feita pelo Carlos
=======
//Alteração realizada por Pedro

//Outra alteração feita pelo Pedro
>>>>>>> pedro

if(lado_1 == lado_2 && lado_1 == lado_3){
    Console.WriteLine("O triângulo é Equilátero");
}
else if(lado_1 == lado_2 || lado_1 == lado_3){
    Console.WriteLine("O triângulo é Isóceles");
}
else{
    Console.WriteLine("O triângulo é Escaleno");
}
