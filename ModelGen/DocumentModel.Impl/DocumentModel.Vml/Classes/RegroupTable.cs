namespace DocumentModel.Vml;

/// <summary>
/// Shape Grouping History.
/// </summary>
public class RegroupTableImpl: ModelElement<DocumentFormat.OpenXml.Vml.Office.RegroupTable>, RegroupTable
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
