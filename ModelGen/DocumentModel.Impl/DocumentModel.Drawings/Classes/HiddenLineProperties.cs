namespace DocumentModel.Drawings;

/// <summary>
/// Defines the HiddenLineProperties Class.
/// </summary>
public class HiddenLinePropertiesImpl: ModelElement<DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties>, HiddenLineProperties
{
  /// <summary>
  /// line cap
  /// </summary>
  public LineCapKind? CapType
  {
    get => (LineCapKind?)OpenXmlElement?.CapType?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.CapType = (DocumentFormat.OpenXml.Drawing.LineCapValues?)value;
    }
  }
  
  /// <summary>
  /// compound line type
  /// </summary>
  public CompoundLineKind? CompoundLineType
  {
    get => (CompoundLineKind?)OpenXmlElement?.CompoundLineType?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.CompoundLineType = (DocumentFormat.OpenXml.Drawing.CompoundLineValues?)value;
    }
  }
  
  /// <summary>
  /// pen alignment
  /// </summary>
  public PenAlignmentKind? Alignment
  {
    get => (PenAlignmentKind?)OpenXmlElement?.Alignment?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Alignment = (DocumentFormat.OpenXml.Drawing.PenAlignmentValues?)value;
    }
  }
  
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
