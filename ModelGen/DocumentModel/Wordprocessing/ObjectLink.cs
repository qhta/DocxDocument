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
  public String? Id
  {
    get => _Element?.Id;
    set => _ExistingElement.Id = value;
  }
  
  
  /// <summary>
  ///   progId
  /// </summary>
  [DataMember]
  public String? ProgId
  {
    get => _Element?.ProgId;
    set => _ExistingElement.ProgId = value;
  }
  
  
  /// <summary>
  ///   shapeId
  /// </summary>
  [DataMember]
  public String? ShapeId
  {
    get => _Element?.ShapeId;
    set => _ExistingElement.ShapeId = value;
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
