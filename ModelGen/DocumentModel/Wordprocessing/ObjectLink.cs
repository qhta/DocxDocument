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
    get
    {
      return BooleanValueConverter.GetValue(_Element?.LockedField);
    }
    set
    {
      _ExistingElement.LockedField = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
  
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
