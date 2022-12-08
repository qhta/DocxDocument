namespace DocumentModel.Drawings;

/// <summary>
/// Defines the DisplayUnits Class.
/// </summary>
public class DisplayUnitsImpl: ModelElementImpl, DisplayUnits
{
  public DocumentFormat.OpenXml.Drawing.Charts.DisplayUnits? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.DisplayUnits?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Double? CustomDisplayUnit
  {
    get;
    set;
  }
  
  public BuiltInUnitKind? BuiltInUnit
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.BuiltInUnit>();
        return (BuiltInUnitKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.BuiltInUnit>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Drawing.Charts.BuiltInUnitValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Drawing.Charts.BuiltInUnit{ Val = (DocumentFormat.OpenXml.Drawing.Charts.BuiltInUnitValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  public DisplayUnitsLabel? DisplayUnitsLabel
  {
    get;
    set;
  }
  
  public ExtensionList4? ExtensionList
  {
    get;
    set;
  }
  
}
