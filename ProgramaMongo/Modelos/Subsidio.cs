using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace ProgramaMongo.Modelos
{
    public class Subsidio
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("Beneficiario")]
        public string Beneficiario { get; set; }

        [BsonElement("ID_Subsidio")]
        public string ID_Subsidio { get; set; }

        [BsonElement("Programa")]
        public string Programa { get; set; }

        [BsonElement("Fecha")]
        public DateTime Fecha { get; set; }

        public Subsidio()
        {
            Id = string.Empty;
            ID_Subsidio = string.Empty;
            Beneficiario = string.Empty;
            Programa = string.Empty;
            Fecha = DateTime.MinValue;
            //Fecha = string.Empty;
            //Id = new ObjectId();
        }
    }
}
