using System.ComponentModel;

namespace Supermarket.API.Domain.Models
{
    public enum EUnitOfMeasurement : byte
    {
        [Description("UN")]
        Unit = 1,

         [Description("MG")]
        Milligram = 2,

         [Description("G")]
        Gram = 3,

         [Description("KG")]
        Kilogram = 4,

         [Description("L")]
        Litre = 5




        
    } 
    
}