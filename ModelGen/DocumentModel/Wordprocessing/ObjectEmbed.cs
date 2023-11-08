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
    get
    {
      return StringValueConverter.GetValue(_Element?.Id);
    }
    set
    {
      _ExistingElement.Id = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   progId
  /// </summary>
  [DataMember]
  public String? ProgId
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.ProgId);
    }
    set
    {
      _ExistingElement.ProgId = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   shapeId
  /// </summary>
  [DataMember]
  public String? ShapeId
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.ShapeId);
    }
    set
    {
      _ExistingElement.ShapeId = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   fieldCodes
  /// </summary>
  [DataMember]
  public String? FieldCodes
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.FieldCodes);
    }
    set
    {
      _ExistingElement.FieldCodes = StringValueConverter.CreateStringValue(value);
    }
  }
  
}
