namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the RelationshipIdType Class.
/// </summary>
public partial class RelationshipIdType: ModelElement<DXDC.RelationshipIdType>
{
  public RelationshipIdType(): base(){ }
  
  public RelationshipIdType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public RelationshipIdType(DXDC.RelationshipIdType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Relationship Reference
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? Id
  {
    get => HexIntConverter.GetValue(_Element?.Id);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
}
