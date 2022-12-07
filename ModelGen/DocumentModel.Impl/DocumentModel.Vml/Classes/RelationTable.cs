namespace DocumentModel.Vml;

/// <summary>
/// Diagram Relationship Table.
/// </summary>
public class RelationTableImpl: ModelElement<DocumentFormat.OpenXml.Vml.Office.RelationTable>, RelationTable
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
