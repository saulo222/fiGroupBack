using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APLICATION_CORE.Class
{
    /// <summary>
    /// Created By :Saul Cruz
    /// Date Created:20/07/2022
    /// Models a Task
    /// </summary>
    public class TaskDTO
    {

        [Key]
        public long idTask { get;  set; }
        public String nameTask { get;  set; }
        public bool state { get;  set; }


    }
}

