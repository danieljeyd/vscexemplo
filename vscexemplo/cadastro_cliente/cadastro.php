<?php
$nomeCliente = $_POST['nomeCliente'];
$telefone = $_POST['phone'];
$email = $_POST['email'];
$cep = $_POST['cep'];
$rua = $_POST['rua'];
$bairro = $_POST['bairro'];
$cidade = $_POST['cidade'];
$uf = $_POST['uf'];
$ibge = $_POST['ibge'];

$strcon = mysqli_connect('localhost', 'daniel', '1234galo','jeyd') ;

if($strcon){
echo(" conectou com banco de dados;");

$sql = "INSERT INTO jeyd.clientes VALUES ";
}
else{
    echo (" Erro ao tentar cadastrar no banco");
}


echo '<script language="javascript">';
echo 'alert("Dados enviados com sucesso!")';
echo '</script>';

$sql .= "('$nomeCliente', '$telefone', '$email', '$cep', '$rua', '$bairro', '$cidade', '$uf', '$ibge')";
mysqli_query( $strcon, $sql ) or die (" Erro ao tentar cadastrar registro");
mysqli_close($strcon);


//echo "<script > location.href='index.html'; </script>";

?>