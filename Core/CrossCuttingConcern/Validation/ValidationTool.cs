using Core.DataAccess.EntityFramework;
using Core.Utilities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcern.Validation
{
    public static class ValidationTool
    {
    public static void Validate()
        {
            var context = new ValidationContext<object>(entity);
             
        }
    
    
    
    
    
    }
}
