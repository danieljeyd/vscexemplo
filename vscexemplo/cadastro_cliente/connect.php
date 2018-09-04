<?php
$host = 'localhost';
$user = 'daniel';
$pass =  '1234galo';
$db = 'jeyd';

$EntradaToken = $_POST['token'];

echo "<br> Token invalido!";

echo "<table border=2>";
echo "<tr>";
echo "<th>Token</th>";
echo "</tr>";


// conecta ao banco de dados
$strcon = mysqli_connect($host, $user, $pass, $db)or die (" <br> Erro ao tentar conectar Banco! ");

//else{
//echo "<br>Conectou certinho!" passa para tela de cadastro;
// echo "<script > location.href='cadtela.html'; </script>";
//}
$sql = "SELECT nomeCliente, token FROM tokens WHERE token = $EntradaToken";
$resultado = mysqli_query($strcon, $sql)or die (" <br> Erro ao tentar consultar dados no Banco! ");
// token para teste: 1234
// Obtendo dados atraves do loop while;

while($registro = mysqli_fetch_array($resultado))
{

$token = $registro['token'];

If($token==null){
    echo "Token invalido";
}
else{

echo "<tr>";
echo "<th>".$token."</th>";
echo "</tr>";


echo '<script language="javascript">';
echo 'alert(" token enviado com sucesso!")';
echo '</script>';
echo "<script > location.href='cadtela.html'; </script>";


}

} 
mysqli_close($strcon);
echo "</table>";

?>


