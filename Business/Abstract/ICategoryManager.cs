using Entities.Concrete;
using Global.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICategoryManager
    {
        IDataResult<List<Category>> GetAll();
        IDataResult<Category> GetById(int? categoryId);
        IDataResult<Category> Add(Category category);
        IDataResult<Category> Delete(Category category);
        IDataResult<Category> Update(Category category);
    }
}
