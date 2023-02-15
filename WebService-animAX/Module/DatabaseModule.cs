using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService_animAX.Module
{
    public class DatabaseModule
    {
        public static ServiceDatabaseEntities db;

        public static ServiceDatabaseEntities GetDbInstance()
        {
            if (db == null) db = new ServiceDatabaseEntities();
            return db;
        }

        public static void SaveDb()
        {
            try
            {
                db.SaveChanges();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                foreach (var entityValidationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in entityValidationErrors.ValidationErrors)
                    {
                        System.Diagnostics.Debug.WriteLine("Property: " + validationError.PropertyName + "\nError: " + validationError.ErrorMessage);
                    }
                }
            }
        }
    }
}