namespace DocumentModel.Vml;

/// <summary>
/// VML Diagram.
/// </summary>
public class DiagramImpl: ModelElement<DocumentFormat.OpenXml.Vml.Office.Diagram>, Diagram
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
  /// Diagram Relationship Table.
  /// </summary>
  public RelationTable? RelationTable
  {
    get;
    set;
  }
  
}
