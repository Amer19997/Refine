

using System.ComponentModel;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using System.Linq;
 

using System.Runtime.Intrinsics.Arm;
using RefineModels.Models.ASR;
using DataAccess.Data;
using RefineModels.Models;
using Refine.Repositories;
using RefineModels.Models.ANRPC;
using Refine.Repositories.IRepository;
using System.Collections.Generic;

public class AnrpcRepository: Repository<AnrpcBase>, IAnrpcRepository
{
        //public AsrTable1 _asrFromFirstTable { get; set; } = new AsrTable1();
        //public AsrTable2 _asrFromSecondTable { get; set; } = new AsrTable2();
        
    //make list of all asr tables from the database and iterate thorough it for each table to be drawn using T genericsw
        private readonly ApplicationDbContext _context;
    public IEnumerable<AnrpcTable1> table1List;
        public IEnumerable<AnrpcTable2> table2List;
        public IEnumerable<AnrpcTable3> table3List;
        public IEnumerable<AnrpcTable4> table4List;
     
        
    public AnrpcRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        table1List = GetEntities<AnrpcTable1>();
        table2List =GetEntities<AnrpcTable2>();
        table3List = GetEntities<AnrpcTable3>();
        table4List = GetEntities<AnrpcTable4>();
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


