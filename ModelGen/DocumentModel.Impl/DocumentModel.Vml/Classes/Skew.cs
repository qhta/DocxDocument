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
  
  public SkewImpl(): base() {}
  
  public SkewImpl(DocumentFormat.OpenXml.Vml.Office.Skew openXmlElement): base(openXmlElement)
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
  /// Skew ID
  /// </summary>
  public String? Id
  {
    get => (System.String?)OpenXmlElement?.Id?.Value;
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
    get => (System.Boolean?)OpenXmlElement?.On?.Value;
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
    get => (System.String?)OpenXmlElement?.Offset?.Value;
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
    get => (System.String?)OpenXmlElement?.Origin?.Value;
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
    get => (System.String?)OpenXmlElement?.Matrix?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Matrix = (System.String?)value;
    }
  }
  
}
