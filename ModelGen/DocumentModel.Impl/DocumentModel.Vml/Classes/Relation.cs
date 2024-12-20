namespace DocumentModel.Vml;

/// <summary>
/// Diagram Relationship.
/// </summary>
public partial class RelationImpl: ModelElementImpl, Relation
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Vml.Office.Relation? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Vml.Office.Relation?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public RelationImpl(): base() {}
  
  public RelationImpl(DocumentFormat.OpenXml.Vml.Office.Relation openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public DocumentModel.Vml.ExtensionHandlingBehaviorKind? Extension
  {
    get => (DocumentModel.Vml.ExtensionHandlingBehaviorKind?)OpenXmlElement?.Extension?.Value;
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
    get => (System.String?)OpenXmlElement?.SourceId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.SourceId = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Diagram Relationship Destination Shape
  /// </summary>
  public String? DestinationId
  {
    get => (System.String?)OpenXmlElement?.DestinationId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DestinationId = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Diagram Relationship Center Shape
  /// </summary>
  public String? CenterShapeId
  {
    get => (System.String?)OpenXmlElement?.CenterShapeId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.CenterShapeId = (System.String?)value;
    }
  }
  
}
