namespace TareasMVC.Entidades
{
    public class Paso
    {
        public Guid Id { get; set; } //3297F0F2-35D3-4231-919D-1CFCF4035975
        public int TareaId { get; set; }//Llave foranea por convencion
        public Tarea Tarea { get; set; }// Propiedad de navegacion para configurar la llave foranea
        public string Descripcion { get; set; }
        public bool Realizado { get; set; }
        public int Orden { get; set; }


    }
}
