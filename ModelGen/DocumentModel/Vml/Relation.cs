namespace DocumentModel.Vml;


/// <summary>
///   Diagram Relationship.
/// </summary>
public partial class Relation: ModelElement<DXVO.Relation>
{
  public Relation(): base(){ }
  
  public Relation(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Relation(DXVO.Relation openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Diagram Relationship Source Shape
  /// </summary>
  [DataMember]
  public String? SourceId
  {
    get => _Element?.SourceId;
    set => _ExistingElement.SourceId = value;
  }
  
  
  /// <summary>
  ///   Diagram Relationship Destination Shape
  /// </summary>
  [DataMember]
  public String? DestinationId
  {
    get => _Element?.DestinationId;
    set => _ExistingElement.DestinationId = value;
  }
  
  
  /// <summary>
  ///   Diagram Relationship Center Shape
  /// </summary>
  [DataMember]
  public String? CenterShapeId
  {
    get => _Element?.CenterShapeId;
    set => _ExistingElement.CenterShapeId = value;
  }
  
}
