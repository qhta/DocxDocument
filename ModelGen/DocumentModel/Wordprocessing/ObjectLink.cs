namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the visual properties, associated server application and refresh mode of an embedded linked object.
/// </summary>
public partial class ObjectLink: ModelElement<DXW.ObjectLink>
{
  public ObjectLink(): base(){ }
  
  public ObjectLink(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ObjectLink(DXW.ObjectLink openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   lockedField
  /// </summary>
  [DataMember]
  public Boolean? LockedField
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
  }
  
  
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
