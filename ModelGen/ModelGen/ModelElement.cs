namespace ModelGen;

public class ModelElement: IOwnedElement
{
  public object? Owner {get; set;}
  public string Name { get; set; }
  public string? Summary { get; set; }
  public Collection<CustomAttribData> CustomAttributes { get; }

  
  public ModelElement(string name)
  {
    Name = name;
    CustomAttributes = new Collection<CustomAttribData>(this);
  }
}