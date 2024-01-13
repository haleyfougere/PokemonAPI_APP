namespace PokemonAPI.Models
{
    public class Pokemon
    {
        public int PokeId { get; set; }
        public int TypeId { get; set; }
        public string PokeName { get; set; } = null!;
        public string PokeDescription { get; set; } = null!;
        public string PokeImage { get; set; } = null!;
        public float PokeHeight { get; set; }
        public float PokeWeight { get; set; }
        public bool IsGood { get; set; }

    }
}
