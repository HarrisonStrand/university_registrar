using System.Collections.Generic;

namespace Registry.Models
{
  public class Course
  {
    public Course()
    {
      this.Students = new HashSet<CourseStudent>();
    }
    public int CourseId { get; set; }
    public string CourseName { get; set; }
    public virtual ICollection<CourseStudent> Students { get; set; }
  }
}