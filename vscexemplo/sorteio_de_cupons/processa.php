<?php
$nome = $_POST['nomeCliente'];
$telefone = $_POST['phone'];
$email = $_POST['email'];
$texto = $_POST['texto'];

$strcon = mysqli_connect('localhost', 'root', 'galo13','jeyd');
if (!$strcon){

    die ('Não foi possível conectar ao MySQL!');

}
    
  
    echo 'Nome do Cliente: '. $nome.'<br>';
    echo 'Telefone do cliente: '.$phone.'<br>';
    echo 'Campo de email: '.$email.'<br>';
    echo 'Campo de Obs: '.$texto.'<br>';
    echo ' conexão realizada com sucesso';
    mysqli_close($strcon);
    
    ?>

    

