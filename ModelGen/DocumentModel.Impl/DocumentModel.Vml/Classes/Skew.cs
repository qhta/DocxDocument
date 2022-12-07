namespace DocumentModel.Vml;

/// <summary>
/// Skew Transform.
/// </summary>
public class SkewImpl: ModelElement<DocumentFormat.OpenXml.Vml.Office.Skew>, Skew
{
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
  
}
