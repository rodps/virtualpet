using System.Collections;

namespace Tamagotchi.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Health { get; set; }
        public float Hunger { get; set; }
        public float Happy { get; set; }
        public string State { get; set; }
        public bool Sleeping { get; set; }

        public IEnumerator GetEnumerator() => (IEnumerator)this;
    }
}