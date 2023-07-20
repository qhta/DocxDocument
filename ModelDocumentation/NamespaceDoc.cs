namespace ModelDocumentation;
public class NamespaceDoc
{
  public NamespaceDoc() { }

  public NamespaceDoc(string name)
  {
    Name = name;
  }

  public string Name {get; set; } = null!;

  public string? Summary {get; set;}

  public Types Types {get; set;} = new();
}
