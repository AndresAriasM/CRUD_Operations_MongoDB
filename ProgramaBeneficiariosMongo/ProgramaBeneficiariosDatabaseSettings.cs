using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaBeneficiariosMongo
{
    public class ProgramaBeneficiariosMongoDatabaseSettings
    {
        public string ConnectionString { get; set; } = null!;

        public string DatabaseName { get; set; } = null!;

        public string DepartamentosCollectionName { get; set; } = null!;

        public string MunicipiosCollectionName { get; set; } = null!;

        public string ProgramasCollectionName { get; set; } = null!;

        public string BeneficiariosCollectionName { get; set; } = null!;

        public string SubsidiosCollectionName { get; set; } = null!;
    }
}
