namespace DesignPattern
{
    public interface IEnemy 
    {
        public string ProductName { get; set; }
        public void Initialize();
        void Attack();
    }
}

