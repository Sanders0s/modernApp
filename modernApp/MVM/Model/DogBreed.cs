using modernApp.Core.Enum;
using System.Runtime.Serialization;

namespace modernApp.MVM.Model
{
    [DataContract]
    public class DogBreed
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Breed { get; set; }
        [DataMember]
        public DogColours Colour { get; set; }
        
        public DogBreed()
        {
        }

        public DogBreed(int id, string breed, DogColours colour)
        {
            Id = id;
            Breed = breed;
            Colour = colour;
        }

        public override string ToString()
        {
            return $"{Id} {Breed} {Colour}";
        }
    }
}
