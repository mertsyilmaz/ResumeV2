using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Global.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryManager
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IDataResult<Category> Add(Category category)
        {
            if (category != null)
                return new SuccessDataResult<Category>(_categoryDal.Add(category), "Category added!");
            else
                return new ErrorDataResult<Category>(category, "Category could not be added!");
        }

        public IDataResult<Category> Delete(Category category)
        {
            if (category != null)
                return new SuccessDataResult<Category>(_categoryDal.Delete(category), "Category deleted!");
            else
                return new ErrorDataResult<Category>(category, "Category could not be deleted!");
        }

        public IDataResult<List<Category>> GetAll()
        {
            var result = new SuccessDataResult<List<Category>>(_categoryDal.GetAll());
            return result;
        }

        public IDataResult<Category> GetById(int? categoryId)
        {
            if (categoryId != null)
                return new SuccessDataResult<Category>(_categoryDal.Get(c => c.Id == categoryId));
            else
                return new ErrorDataResult<Category>("Category not found!");
        }

        public IDataResult<Category> Update(Category category)
        {
            if (category != null)
                return new SuccessDataResult<Category>(_categoryDal.Update(category), "Category updated!");
            else
                return new ErrorDataResult<Category>(category, "Category could not be updated!");
        }
    }
}
