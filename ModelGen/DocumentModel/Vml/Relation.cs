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
  public DocumentModel.HexInt? SourceId
  {
    get => HexIntConverter.GetValue(_Element?.SourceId);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   Diagram Relationship Destination Shape
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? DestinationId
  {
    get => HexIntConverter.GetValue(_Element?.DestinationId);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   Diagram Relationship Center Shape
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? CenterShapeId
  {
    get => HexIntConverter.GetValue(_Element?.CenterShapeId);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
}
