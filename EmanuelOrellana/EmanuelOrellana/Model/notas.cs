//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmanuelOrellana.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class notas
    {
        public int id_notas { get; set; }
        public Nullable<int> id_estudiante { get; set; }
        public Nullable<int> id_materia { get; set; }
        public Nullable<double> notas1 { get; set; }
    
        public virtual estudiante estudiante { get; set; }
        public virtual materia materia { get; set; }
    }
}
