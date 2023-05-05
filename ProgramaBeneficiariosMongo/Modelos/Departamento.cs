using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace ProgramaBeneficiariosMongo.Modelos
{
    public class Departamento
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("ID_Departamento")]
        public int ID_Departamento { get; set; }

        [BsonElement("Nombre_Departamento")]
        public string Nombre_Departamento { get; set; }

        public Departamento()
        {
            Id = string.Empty;
            ID_Departamento = 0;
            Nombre_Departamento = string.Empty;
        }
    }

}
