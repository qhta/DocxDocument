using System.ComponentModel.DataAnnotations;

namespace ModelDoc;
public class Namespace
{
  public Namespace() { }

  public Namespace(string name, string? prefix)
  {
    FullName = name;
    Prefix = prefix;
  }

  public int Id { get; set; }

  [MaxLength(255)]
  public string FullName {get; set; } = null!;

  [MaxLength(10)]
  public string? Prefix {get; set;}

  //public Types Types {get; set;} = new();
}
