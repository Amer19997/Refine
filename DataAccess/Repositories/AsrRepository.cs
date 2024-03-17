

using System.ComponentModel;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using System.Linq;
 

using System.Runtime.Intrinsics.Arm;
using RefineModels.Models.ASR;
using DataAccess.Data;
using RefineModels.Models;
using Refine.Repositories;
using Refine.Repositories.IRepository;
using System.Collections.Generic;

public class AsrRepository: Repository<AsrBase>, IAsrRepository
{
        //public AsrTable1 _asrFromFirstTable { get; set; } = new AsrTable1();
        //public AsrTable2 _asrFromSecondTable { get; set; } = new AsrTable2();
        
    //make list of all asr tables from the database and iterate thorough it for each table to be drawn using T genericsw
        private readonly ApplicationDbContext _context;
        public  IEnumerable<AsrTable1> table1List;
        public IEnumerable<AsrTable2> table2List;
        public IEnumerable<AsrTable3> table3List;
        public IEnumerable<AsrTable4> table4List;
        public IEnumerable<AsrTable5> table5List;
        public IEnumerable<AsrBase> combinedList;

 

    public AsrRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
       table1List = GetEntities<AsrTable1>();
       table2List =GetEntities<AsrTable2>();
        table3List = GetEntities<AsrTable3>();
        table4List = GetEntities<AsrTable4>();
        table5List = GetEntities<AsrTable5>();
        //combinedList =CombineAsrLists<AsrBase>(table1List, table2List);

    }

 
   
        //public List<AsrTable1> GetAsrEntities()
        //{
        //    List<AsrTable1> AsrEntitiesmodel = _context.AsrEntities.ToList();
        //    return AsrEntitiesmodel;
        //}
        //public List<AsrTable2> GetDistillationProducts()
        //{
        //    List<AsrTable2> DistillationProducts = _context.AsrDistillationProducts.ToList();
        //    return DistillationProducts;
        //}

 

    //public List<AsrBase> CombineAsrLists<T>(params IEnumerable<T>[] lists) where T : AsrBase
    //{
    //    List<AsrBase> combinedList = new List<AsrBase>();

    //    foreach (IEnumerable<T> list in lists)
    //    {
    //        combinedList.AddRange(list.Cast<AsrBase>());
    //    }

    //    return combinedList;
    //}



    //public List<Asr> CombineLists<Asr>(params List<Asr>[] lists)
    //{

    //    List<Asr> combinedList = new List<Asr>();

    //    foreach (List<Asr> list in lists)
    //    {
    //        combinedList.AddRange(list);
    //    }

    //    return combinedList;
    //}

    //List<Asr> IAsrRepository.CombineLists<T>(params List<T>[] lists)
    //{
    //    throw new NotImplementedException();
    //}
}


