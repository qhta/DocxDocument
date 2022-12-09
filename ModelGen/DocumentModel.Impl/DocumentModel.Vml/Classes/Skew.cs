namespace DocumentModel.Vml;

/// <summary>
/// Skew Transform.
/// </summary>
public class SkewImpl: ModelElementImpl, Skew
{
  public DocumentFormat.OpenXml.Vml.Office.Skew? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Vml.Office.Skew?)_OpenXmlElement;
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
  /// Skew ID
  /// </summary>
  public String? Id
  {
    get => (String?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Skew Toggle
  /// </summary>
  public Boolean? On
  {
    get => (Boolean?)OpenXmlElement?.On?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.On = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Skew Offset
  /// </summary>
  public String? Offset
  {
    get => (String?)OpenXmlElement?.Offset?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Offset = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Skew Origin
  /// </summary>
  public String? Origin
  {
    get => (String?)OpenXmlElement?.Origin?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Origin = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Skew Perspective Matrix
  /// </summary>
  public String? Matrix
  {
    get => (String?)OpenXmlElement?.Matrix?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Matrix = (System.String?)value;
    }
  }
  
}
