namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the RelationshipType Class.
/// </summary>
public partial class RelationshipType: ModelElement<DXW.RelationshipType>
{
  public RelationshipType(): base(){ }
  
  public RelationshipType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public RelationshipType(DXW.RelationshipType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Relationship to Part
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? Id
  {
    get => HexIntConverter.GetValue(_Element?.Id);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
}
