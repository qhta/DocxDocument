namespace DocumentModel.Vml;

/// <summary>
/// Diagram Relationship Table.
/// </summary>
public class RelationTableImpl: ModelElementImpl, RelationTable
{
  public DocumentFormat.OpenXml.Vml.Office.RelationTable? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Vml.Office.RelationTable?)_OpenXmlElement;
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
  
  public Collection<Relation>? Relations
  {
    get;
    set;
  }
  
}
