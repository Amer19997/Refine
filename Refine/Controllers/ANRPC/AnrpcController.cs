using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Refine.Repositories.IRepository;
using RefineModels.Models;
using RefineModels.Models.ANRPC;
 
namespace Refine.ANRPC.Controllers
{
    [Authorize(Roles = "Anrpc")]
    public class AnrpcController : Controller
    {

        private readonly IUnitOfWork _unitOfWork;
        public AnrpcController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index(int id)
        {
            ViewBag.id = id;
            return View(_unitOfWork.Anrpc);
        }
        public IActionResult Categories()
        {
            return View("AnrpcCategories", _unitOfWork.Anrpc);
        }

        [HttpPost]
        public IActionResult UpdateAll([FromBody] List<UpdateItemDto> updatedItems)
        {
            if (ModelState.IsValid)
            {
                foreach (var updateItem in updatedItems)
                {
                    List<AnrpcBase> AllTables = new List<AnrpcBase>();

                    AnrpcTable1 firstTableEntity = _unitOfWork.Anrpc.GetEntityById<AnrpcTable1>(updateItem.Id);
                    AnrpcTable2 secondTableEntity = _unitOfWork.Anrpc.GetEntityById<AnrpcTable2>(updateItem.Id);
                    AnrpcTable3 thirdTableEntity = _unitOfWork.Anrpc.GetEntityById<AnrpcTable3>(updateItem.Id);
                    AnrpcTable4 FourthTableEntity = _unitOfWork.Anrpc.GetEntityById<AnrpcTable4>(updateItem.Id);
                    AllTables.Add(firstTableEntity);
                    AllTables.Add(secondTableEntity);
                    AllTables.Add(thirdTableEntity);
                    AllTables.Add(FourthTableEntity);
 
                    // ssuming _AnrpcViewRepository.GetEntityById<T> returns null if the entity is not found.
                    foreach (var table in AllTables)
                    {
                        if (updatedItems != null)
                        {
                            if (table != null)
                            {
                                _unitOfWork.Anrpc.UpdateEntity(table, updateItem);
                            }

                        }
                    }
                }
            }
            // Return appropriate IActionResult here, e.g., Ok() or BadRequest()
            return RedirectToAction("Index");
            // Also, make sure to handle errors and return the appropriate response if the ModelState is not valid.
        }



    }
}

