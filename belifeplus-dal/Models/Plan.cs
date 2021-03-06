namespace BeLife.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Plan")]
    public partial class Plan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Plan()
        {
            Contrato = new HashSet<Contrato>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(5)]
        public string IdPlan { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdTipoContrato { get; set; }

        [Required]
        [StringLength(20)]
        public string Nombre { get; set; }

        public double PrimaBase { get; set; }

        [Required]
        [StringLength(15)]
        public string PolizaActual { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contrato> Contrato { get; set; }

        public virtual TipoContrato TipoContrato { get; set; }
    }
}
