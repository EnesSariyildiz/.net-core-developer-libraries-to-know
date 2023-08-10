﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Solid.App.DIPGoodAndBad
{

    public class ProductService
    {

        private readonly IRepository _repository;

        public ProductService(IRepository repository)
        {
            _repository = repository;
        }

        public List<string> GetAll()
        {
            return _repository.GetAll();
        }




    }

    public class ProductRepositoryFromSql : IRepository
    {
        public List<string> GetAll()
        {
            return new List<string>() { "SqlServerKalem 1", "SqlServerKalem 2" };
        }
    }

    public class ProductRepositoryFromOracle : IRepository
    {
        public List<string> GetAll()
        {
            return new List<string>() { "OracleKalem 1", "OracleKalem 2" };
        }
    }

    public interface IRepository
    {
        public List<string> GetAll();
    }
}
