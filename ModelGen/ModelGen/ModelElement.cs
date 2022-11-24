using System.Diagnostics;
using System.Xml;
using System.Xml.Linq;

namespace ModelGen;

public class ModelElement: IOwnedElement
{
  public object? Owner {get; set;}
  public string Name { get; set; }

  public bool? IsAccepted
  {
    get => _IsAccepted;
    set
    {
      if (_IsAccepted == value) return;
      if (value==true && this is TypeInfo typeInfo)
      {
        if (typeInfo.Name=="EnumValue")
        //if (typeInfo.GetFullName(false, true) == "IEnumValue<DocumentFormat.OpenXml.Office2013.Word.SdtAppearance>")
          Debug.Assert(true);
      }
      _IsAccepted = value;
    }
  }
  private bool? _IsAccepted;

  public string? Summary { get; set; }

  public XElement? Documentation { get; set; }

  public Collection<CustomAttribData> CustomAttributes { get; }

  
  public ModelElement(string name)
  {
    Name = name;
    CustomAttributes = new Collection<CustomAttribData>(this);
  }
}