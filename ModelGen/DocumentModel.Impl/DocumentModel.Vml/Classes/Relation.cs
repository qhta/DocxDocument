namespace DocumentModel.Vml;

/// <summary>
/// Diagram Relationship.
/// </summary>
public class RelationImpl: ModelElementImpl, Relation
{
  public DocumentFormat.OpenXml.Vml.Office.Relation? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Vml.Office.Relation?)_OpenXmlElement;
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
  /// Diagram Relationship Source Shape
  /// </summary>
  public String? SourceId
  {
    get;
    set;
  }
  
  /// <summary>
  /// Diagram Relationship Destination Shape
  /// </summary>
  public String? DestinationId
  {
    get;
    set;
  }
  
  /// <summary>
  /// Diagram Relationship Center Shape
  /// </summary>
  public String? CenterShapeId
  {
    get;
    set;
  }
  
}
