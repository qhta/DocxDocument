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
