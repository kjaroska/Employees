namespace kJaroska.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            Managers = new HashSet<Employee>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "Employee Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(60)]
        public string LastName { get; set; }

        [Display(Name = "Hire Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")] //TODO: make universal per userCulture
        public DateTime HireDate { get; set; }

        [Required]
        [StringLength(100)]
        public string Department { get; set; }

        public int? Grade { get; set; }

        [Display(Name="Performance Manager")]
        public int ManagerId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee> Managers { get; set; }

        public virtual Employee Manager { get; set; }
    }
}
