//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaVentasPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_MENU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_MENU()
        {
            this.TB_MENU_ROL = new HashSet<TB_MENU_ROL>();
        }
    
        public int id_menu { get; set; }
        public string nombre { get; set; }
        public string url { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_MENU_ROL> TB_MENU_ROL { get; set; }
    }
}