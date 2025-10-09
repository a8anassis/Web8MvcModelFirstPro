namespace SchoolApp.Data
{
    public class Course : BaseEntity
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int? TeacherId { get; set; }
        public virtual Teacher? Teacher { get; set; } = null!;
        public virtual ICollection<Student> Students { get; set; } = new HashSet<Student>();
    }
}
