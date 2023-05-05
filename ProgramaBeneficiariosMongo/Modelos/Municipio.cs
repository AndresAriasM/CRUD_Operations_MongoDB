using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace ProgramaBeneficiariosMongo.Modelos
{
    public class Municipio
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("ID_Municipio")]
        public int ID_Municipio { get; set; }

        [BsonElement("Nombre_Municipio")]
        public string Nombre_Municipio { get; set; }

        [BsonElement("Departamento")]
        public int Departamento { get; set; }

        public Municipio()
        {
            Id = string.Empty;
            ID_Municipio = 0;
            Nombre_Municipio = string.Empty;
            Departamento = 0;
        }
    }
}
