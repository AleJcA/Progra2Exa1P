
using System;
using Yu_Gi_Oh__Exam_.Modelos;



CMonstruo CartaM = new CMonstruo()
{
    NombreC = "Mago del tiempo",
    Descrip = "Una vez por turno puedes lanzar una moneda y elegir cara o cruz",
    Atributo = "Tierra",
    Nivel = 2,
    Atk = 500,
    Def = 400
};


CMagica CartaMagica = new CMagica
{
    NombreC = "Sello del propitario",
    Categoria = "Normal",
    Efecto = "Devuelve a sus dueños el control de todos los monstruos en el campo"
};

CTrampa CartaT = new CTrampa
{
    NombreC = "Llamado del cementerio",
    Categoria = "Normal",
    Efecto = "Puedes recuperar una carta del cementerio"
};

Console.WriteLine(CartaM.toString());
Console.WriteLine(CartaMagica.toString());
Console.WriteLine(CartaT.toString());