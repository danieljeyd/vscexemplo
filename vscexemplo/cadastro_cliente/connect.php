<?php


$nomeCliente = $_POST['nomeCliente'];
$token = $_POST['token'];

$strcon = mysqli_connect('localhost', 'daniel', '1234galo','jeyd')or die ('Erro ao conexão');

if($strcon){

    echo '<script language="javascript">';
    echo 'alert("Token conectou com banco de dados!")';
    echo '</script>';
    $Consulta = mysql_num_rows(mysql_query("SELECT nomeCliente,token FROM tokens WHERE nomeCliente= '$nomeCliente', token= '$token' "));
    if ($Consulta != 0) {

        echo " ok token!";
        
        echo "<script > location.href='cadtela.html'; </script>";

    }else
    {
echo " token invalido";
        
    }

}

else{
    echo "não conectou ao banco de dados";
}


?>