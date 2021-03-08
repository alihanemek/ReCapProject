﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //generic   constraint(generic kısıt) bu kısıt ile sadece db tablo claslarını vermesini sağlıyoruz
    //class:referans tip 
    //IEntity olamalı yada ıentity implemente etmeli
    //new diyerek sadece newlenebilen olduğunu gösterdik yani ıentity de olamaz artık çünkü newlenmiyor Soyut somut olayı
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        
    }
}
