namespace DocumentModel.Vml;

/// <summary>
/// Most Recently Used Colors.
/// </summary>
public class ColorMostRecentlyUsedImpl: ModelElementImpl, ColorMostRecentlyUsed
{
  public DocumentFormat.OpenXml.Vml.Office.ColorMostRecentlyUsed? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Vml.Office.ColorMostRecentlyUsed?)_OpenXmlElement;
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
  /// Recent colors
  /// </summary>
  public String? Colors
  {
    get => (String?)OpenXmlElement?.Colors?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Colors = (System.String?)value;
    }
  }
  
}
