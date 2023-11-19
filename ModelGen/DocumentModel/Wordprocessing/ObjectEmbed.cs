namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the visual properties and associated server application of an embedded object.
/// </summary>
public partial class ObjectEmbed: ModelElement<DXW.ObjectEmbed>
{
  public ObjectEmbed(): base(){ }
  
  public ObjectEmbed(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ObjectEmbed(DXW.ObjectEmbed openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   id
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? Id
  {
    get => HexIntConverter.GetValue(_Element?.Id);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   progId
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? ProgId
  {
    get => HexIntConverter.GetValue(_Element?.ProgId);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   shapeId
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? ShapeId
  {
    get => HexIntConverter.GetValue(_Element?.ShapeId);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   fieldCodes
  /// </summary>
  [DataMember]
  public String? FieldCodes
  {
    get => _Element?.FieldCodes;
    set => _ExistingElement.FieldCodes = value;
  }
  
}
