using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAppNTier.Business.Interfaces;
using ToDoAppNTier.DataAccess.UnitOfWork;
using ToDoAppNTier.Dtos.WorkDtos;
using ToDoAppNTier.Entities.Domains;

namespace ToDoAppNTier.Business.Services
{

    public class WorkService : IWorkService
    {
        private readonly IUow _uow;

        public WorkService(IUow uow)
        {
            _uow = uow;
        }
        public async Task Create(WorkCreateDto dto)
        {
            await _uow.GetRepository<Work>().Create(new()
            {
                IsComplete = dto.IsComplete,
                Definition = dto.Definition
            });
            await _uow.SaveChanges();
        }
        public async Task<List<WorkListDto>> GetAll()
        {
            var list = await _uow.GetRepository<Work>().GetAll();
            var workList = new List<WorkListDto>();
            if (list != null && list.Count() > 0)
            {
                foreach (var work in list)
                {
                    workList.Add(new()
                    {
                        Definition = work.Definition,
                        Id = work.Id,
                        IsComplete = work.IsComplete,
                    });
                }
            }
            return workList;
        }
        public async Task<WorkListDto> GetById(object id)
        {
            var work = await _uow.GetRepository<Work>().GetById(id);
            return new()
            {
                Definition = work.Definition,
                IsComplete = work.IsComplete
            };
        }

        public async Task Remove(object id)
        {
            var deletedWork = await _uow.GetRepository<Work>().GetById(id);
            _uow.GetRepository<Work>().Remove(deletedWork);
            await _uow.SaveChanges();
        }

        public async Task Update(WorkUpdateDto dto)
        {
            _uow.GetRepository<Work>().Update(new()
            {
                Definition = dto.Definition,
                Id = dto.Id,
                IsComplete = dto.IsComplete,
            });
            await _uow.SaveChanges();
        }
    }
}
