namespace tiwar_copy_Backend.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string? Login { get; set; }
        public string? Password { get; set; }
        public string? Gender { get; set; }
        public string? Class { get; set; }
        public int Level { get; set; }
        public int Exp { get; set; }
        public int Balance { get; set; }
        public int Attack { get; set; }
        public int Weapon { get; set; }
        public bool Quest1 { get; set; }
        public bool Quest2 { get; set; }
        public bool Quest3 { get; set; }
        public bool Quest4 { get; set; }
        public bool Quest5 { get; set; }
        public bool Quest6 { get; set; }
        public bool Weapon1_Buying { get; set; }
        public bool Weapon2_Buying { get; set; }
    }
}
