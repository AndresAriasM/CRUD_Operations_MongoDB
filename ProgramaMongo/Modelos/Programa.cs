using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace ProgramaMongo.Modelos
{
    public class Programa
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("ID_Programa")]
        public int ID_Programa { get; set; }

        [BsonElement("Nombre_Programa")]
        public string Nombre_Programa { get; set; }

        [BsonElement("Valor")]
        public int Valor { get; set; }

        public Programa()
        {
            Id = string.Empty;
            ID_Programa = 0;
            Nombre_Programa = string.Empty;
            Valor = 0;
        }

        /*public static implicit operator Programa(Programa v)
        {
            throw new NotImplementedException();
        }*/
    }
}
