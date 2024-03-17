

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
 
using Refine.Repositories;
using Refine.Repositories.IRepository;
using RefineModels.Models;
using RefineModels.Models.ASR;
namespace BulkyWeb.Controllers
{
    //[Authorize(Roles = "Asr")]
    public class AsrController : Controller
    {

        private readonly IUnitOfWork _unitOfWork;
        public AsrController(IUnitOfWork unitOfWork)
        {

            _unitOfWork = unitOfWork;
        }
        public IActionResult Index(int id)
        {
            ViewBag.id = id;
            return View(_unitOfWork.Asr);
        }
       public IActionResult Categories()
        {
            return View("AsrCategories", _unitOfWork.Asr);
        }
   

        [HttpPost]
        public IActionResult UpdateAll([FromBody] List<UpdateItemDto> updatedItems)
        {
            if (ModelState.IsValid)
            {
                foreach (var updateItem in updatedItems)
                {
                    List<AsrBase>AllTables=new List<AsrBase>();
                    
                    AsrTable1 firstTableEntity = _unitOfWork.Asr.GetEntityById<AsrTable1>(updateItem.Id);
                    AsrTable2 secondTableEntity = _unitOfWork.Asr.GetEntityById<AsrTable2>(updateItem.Id);
                    AsrTable3 thirdTableEntity = _unitOfWork.Asr.GetEntityById<AsrTable3>(updateItem.Id);
                    AsrTable4 FourthTableEntity = _unitOfWork.Asr.GetEntityById<AsrTable4>(updateItem.Id);
                    AsrTable5 FifthTableEntity = _unitOfWork.Asr.GetEntityById<AsrTable5>(updateItem.Id);
                    AllTables.Add(firstTableEntity);
                    AllTables.Add(secondTableEntity);
                    AllTables.Add(thirdTableEntity);
                    AllTables.Add(FourthTableEntity);
                    AllTables.Add(FifthTableEntity);

                    // ssuming _asrViewRepository.GetEntityById<T> returns null if the entity is not found.
                    foreach (var table in AllTables)
                    {
                             if (updatedItems != null)
                    {
                        if(table!= null)
                        {
                            _unitOfWork.Asr.UpdateEntity(table, updateItem);
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

