using System.ComponentModel.DataAnnotations;
using System;
using DOMAIN_CORE.Class.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace DOMAIN_CORE.Class
{
    /// <summary>
    /// Created By :Saul Cruz
    /// Date Created:20/07/2022
    /// Models a Task
    /// </summary>
    public class Tasks 
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long idTask { get;  set; }
        public String nameTask { get;  set; }
        public bool state { get;  set; }


    }
}
