using System.Diagnostics;
using System.Xml;
using System.Xml.Linq;

namespace ModelGen;

public class ModelElement: IOwnedElement
{
  public object? Owner {get; set;}
  public string Name { get; set; }

  public bool? IsAccepted { get; set; }
  public bool? IsUsed { get; set; }
  public bool IsConverted { get; set; }

  public string? Summary { get; set; }

  public XElement? Documentation { get; set; }

  public OwnedCollection<CustomAttribData> CustomAttributes { get; }

  
  public ModelElement(string name)
  {
    Name = name;
    CustomAttributes = new OwnedCollection<CustomAttribData>(this);
  }
}