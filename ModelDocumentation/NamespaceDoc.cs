namespace ModelDocumentation;
public class NamespaceDoc
{
  public NamespaceDoc(string name)
  {
    Name = name;
  }

  public string Name {get; private set; }
  public string? Summary {get; private set;}

  public Types Types {get; private set;} = new();
}
