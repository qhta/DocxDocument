namespace DocumentModel.Vml;

/// <summary>
/// Defines the Callout Class.
/// </summary>
public class CalloutImpl: ModelElementImpl, Callout
{
  public DocumentFormat.OpenXml.Vml.Office.Callout? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Vml.Office.Callout?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorKind? Extension
  {
    get => (ExtensionHandlingBehaviorKind?)OpenXmlElement?.Extension?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Extension = (DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues?)value;
    }
  }
  
  /// <summary>
  /// Callout toggle
  /// </summary>
  public Boolean? On
  {
    get;
    set;
  }
  
  /// <summary>
  /// Callout type
  /// </summary>
  public String? Type
  {
    get;
    set;
  }
  
  /// <summary>
  /// Callout gap
  /// </summary>
  public String? Gap
  {
    get;
    set;
  }
  
  /// <summary>
  /// Callout angle
  /// </summary>
  public AngleKind? Angle
  {
    get => (AngleKind?)OpenXmlElement?.Angle?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Angle = (DocumentFormat.OpenXml.Vml.Office.AngleValues?)value;
    }
  }
  
  /// <summary>
  /// Callout automatic drop toggle
  /// </summary>
  public Boolean? DropAuto
  {
    get;
    set;
  }
  
  /// <summary>
  /// Callout drop position
  /// </summary>
  public String? Drop
  {
    get;
    set;
  }
  
  /// <summary>
  /// Callout drop distance
  /// </summary>
  public String? Distance
  {
    get;
    set;
  }
  
  /// <summary>
  /// Callout length toggle
  /// </summary>
  public Boolean? LengthSpecified
  {
    get;
    set;
  }
  
  /// <summary>
  /// Callout length
  /// </summary>
  public String? Length
  {
    get;
    set;
  }
  
  /// <summary>
  /// Callout accent bar toggle
  /// </summary>
  public Boolean? AccentBar
  {
    get;
    set;
  }
  
  /// <summary>
  /// Callout text border toggle
  /// </summary>
  public Boolean? TextBorder
  {
    get;
    set;
  }
  
  /// <summary>
  /// Callout flip x
  /// </summary>
  public Boolean? MinusX
  {
    get;
    set;
  }
  
  /// <summary>
  /// Callout flip y
  /// </summary>
  public Boolean? MinusY
  {
    get;
    set;
  }
  
}
