namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Outline Class.
/// </summary>
public class OutlineImpl: DocumentModel.Drawings.LinePropertiesTypeImpl, Outline
{
  public SolidFill? SolidFill
  {
    get;
    set;
  }
  
  public GradientFill? GradientFill
  {
    get;
    set;
  }
  
  public PatternFill? PatternFill
  {
    get;
    set;
  }
  
  public PresetLineDashKind? PresetDash
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.PresetDash>();
        return (PresetLineDashKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.PresetDash>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Drawing.PresetLineDashValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Drawing.PresetDash{ Val = (DocumentFormat.OpenXml.Drawing.PresetLineDashValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  public CustomDash? CustomDash
  {
    get;
    set;
  }
  
  public Miter? Miter
  {
    get;
    set;
  }
  
  public LineEndPropertiesType? HeadEnd
  {
    get;
    set;
  }
  
  public LineEndPropertiesType? TailEnd
  {
    get;
    set;
  }
  
  public LinePropertiesExtensionList? LinePropertiesExtensionList
  {
    get;
    set;
  }
  
}
