//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace planes_prueba
{
    using System;
    using System.Collections.Generic;
    
    public partial class PPI_TBL_PLAN_PRUEBAS
    {
        public long ID_PRUEBAS { get; set; }
        public Nullable<long> CODIGO_PROYECTO { get; set; }
        public Nullable<long> LIDER_PDS_PROYECTO { get; set; }
        public Nullable<long> LIDER_PDS_RESPONSABLE { get; set; }
        public Nullable<System.DateTime> FECHA_CREACION { get; set; }
        public Nullable<System.DateTime> FECHA_EVALUACION { get; set; }
        public Nullable<System.DateTime> FECHA_MODIFICACION { get; set; }
        public string DESCRIPCION { get; set; }
        public string DATOS_PRUEBA { get; set; }
        public string CONCLUSIONES { get; set; }
        public string MODULO { get; set; }
        public Nullable<long> CREADOR_POR { get; set; }
        public Nullable<int> ESTADO { get; set; }
    
        public virtual PPI_TBL_LIDER_PDS PPI_TBL_LIDER_PDS { get; set; }
        public virtual PPI_TBL_LIDER_PDS PPI_TBL_LIDER_PDS1 { get; set; }
    }
}