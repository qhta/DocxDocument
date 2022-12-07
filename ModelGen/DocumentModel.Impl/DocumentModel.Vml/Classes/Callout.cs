namespace DocumentModel.Vml;

/// <summary>
/// Defines the Callout Class.
/// </summary>
public class CalloutImpl: ModelElement<DocumentFormat.OpenXml.Vml.Office.Callout>, Callout
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
  
}
