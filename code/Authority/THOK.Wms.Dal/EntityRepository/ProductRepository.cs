﻿using THOK.Wms.DbModel;
using THOK.Wms.Dal.Interfaces;
using THOK.Common.Ef.EntityRepository;

namespace THOK.Wms.Dal.EntityRepository
{
    public class ProductRepository:RepositoryBase<Product>,IProductRepository
    {
    }
}
