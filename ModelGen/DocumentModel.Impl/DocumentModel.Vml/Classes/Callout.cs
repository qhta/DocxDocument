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
  
  public CalloutImpl(): base() {}
  
  public CalloutImpl(DocumentFormat.OpenXml.Vml.Office.Callout openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public DocumentModel.Vml.ExtensionHandlingBehaviorKind? Extension
  {
    get => (DocumentModel.Vml.ExtensionHandlingBehaviorKind?)OpenXmlElement?.Extension?.Value;
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
    get => (System.Boolean?)OpenXmlElement?.On?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.On = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Callout type
  /// </summary>
  public String? Type
  {
    get => (System.String?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Callout gap
  /// </summary>
  public String? Gap
  {
    get => (System.String?)OpenXmlElement?.Gap?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Gap = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Callout angle
  /// </summary>
  public DocumentModel.Vml.AngleKind? Angle
  {
    get => (DocumentModel.Vml.AngleKind?)OpenXmlElement?.Angle?.Value;
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
    get => (System.Boolean?)OpenXmlElement?.DropAuto?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DropAuto = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Callout drop position
  /// </summary>
  public String? Drop
  {
    get => (System.String?)OpenXmlElement?.Drop?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Drop = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Callout drop distance
  /// </summary>
  public String? Distance
  {
    get => (System.String?)OpenXmlElement?.Distance?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Distance = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Callout length toggle
  /// </summary>
  public Boolean? LengthSpecified
  {
    get => (System.Boolean?)OpenXmlElement?.LengthSpecified?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.LengthSpecified = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Callout length
  /// </summary>
  public String? Length
  {
    get => (System.String?)OpenXmlElement?.Length?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Length = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Callout accent bar toggle
  /// </summary>
  public Boolean? AccentBar
  {
    get => (System.Boolean?)OpenXmlElement?.AccentBar?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.AccentBar = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Callout text border toggle
  /// </summary>
  public Boolean? TextBorder
  {
    get => (System.Boolean?)OpenXmlElement?.TextBorder?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.TextBorder = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Callout flip x
  /// </summary>
  public Boolean? MinusX
  {
    get => (System.Boolean?)OpenXmlElement?.MinusX?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.MinusX = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Callout flip y
  /// </summary>
  public Boolean? MinusY
  {
    get => (System.Boolean?)OpenXmlElement?.MinusY?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.MinusY = (System.Boolean?)value;
    }
  }
  
}
