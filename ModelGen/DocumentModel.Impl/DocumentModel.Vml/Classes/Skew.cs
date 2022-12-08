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
    get;
    set;
  }
  
  /// <summary>
  /// Skew Toggle
  /// </summary>
  public Boolean? On
  {
    get;
    set;
  }
  
  /// <summary>
  /// Skew Offset
  /// </summary>
  public String? Offset
  {
    get;
    set;
  }
  
  /// <summary>
  /// Skew Origin
  /// </summary>
  public String? Origin
  {
    get;
    set;
  }
  
  /// <summary>
  /// Skew Perspective Matrix
  /// </summary>
  public String? Matrix
  {
    get;
    set;
  }
  
}
