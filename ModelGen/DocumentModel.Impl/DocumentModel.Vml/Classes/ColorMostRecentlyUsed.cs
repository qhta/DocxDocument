namespace DocumentModel.Vml;

/// <summary>
/// Most Recently Used Colors.
/// </summary>
public class ColorMostRecentlyUsedImpl: ModelElement<DocumentFormat.OpenXml.Vml.Office.ColorMostRecentlyUsed>, ColorMostRecentlyUsed
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
