using Solid.App.DIPGoodAndBad;
using System.ComponentModel;

var ProductService = new ProductService(new ProductRepositoryFromOracle());

ProductService.GetAll().ForEach(x => Console.WriteLine(x));