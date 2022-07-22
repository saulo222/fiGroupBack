using APLICATION_AGGREGATES.Aggregates.Commands;
using APLICATION_CORE.Class;
using APLICATION_CORE.Mappers;
using AutoMapper;
using DOMAIN_AGGREGATES.GetTask.Commands;
using DOMAIN_CORE.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APLICATION_IMPLEMENTATION.Implementation.GetTask.Commands
{
    /// <summary>
    /// Created by: Saul Cruz
    /// Date Created: 20/07/2022
    /// Service that contains the operations that a property implements.
    /// </summary>
    public class TaskServices : ITaskServices
    {

        private ITask _task;
        public TaskServices(ITask task

                               )
        {
            _task = task;

        }

        public async Task<bool> Add(TaskDTO taskdto)
        {

            var config = new MapperConfiguration(cfg => {
                cfg.AddProfile<MapperProfile>();
            });
            int result = 0;
            Tasks tasks = new Tasks();
            var mapper = config.CreateMapper();
            mapper.Map(taskdto, tasks);
             await _task.Add(tasks);
            result = _task.WorkUnit.Save();
            _task.Dispose();
            return result > 0 ? true : false;
        }

        public  bool Update(TaskDTO taskdto)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.AddProfile<MapperProfile>();
            });
            int result = 0;
            Tasks tasks = new Tasks();
            var mapper = config.CreateMapper();
            mapper.Map(taskdto, tasks);
             _task.Update(tasks);
            result = _task.WorkUnit.Save();
            _task.Dispose();
            return result > 0 ? true : false;
        }

        public bool Delete(TaskDTO taskdto)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.AddProfile<MapperProfile>();
            });
            int result = 0;
            Tasks tasks = new Tasks();
            var mapper = config.CreateMapper();
            mapper.Map(taskdto, tasks);
            _task.Delete(tasks);
            result = _task.WorkUnit.Save();
            _task.Dispose();
            return result > 0 ? true : false;
        }

        public void Dispose()
        {
            _task.Dispose();
        }
    }
}
