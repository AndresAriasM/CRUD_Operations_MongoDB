using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace ProgramaMongo.Modelos
{
    public class Beneficiario
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("ID_Beneficiario")]
        public int ID_Beneficiario { get; set; }

        [BsonElement("Nombre_Beneficiario")]
        public string Nombre_Beneficiario { get; set; }

        [BsonElement("Municipio")]
        public string Municipio { get; set; }

        public Beneficiario()
        {
            Id = string.Empty;
            ID_Beneficiario = 0;
            Nombre_Beneficiario = string.Empty;
            Municipio = string.Empty;
        }
    }

}
