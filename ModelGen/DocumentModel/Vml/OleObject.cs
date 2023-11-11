namespace DocumentModel.Vml;


/// <summary>
///   Embedded OLE Object.
/// </summary>
public partial class OleObject: ModelElement<DXVO.OleObject>
{
  public OleObject(): base(){ }
  
  public OleObject(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public OleObject(DXVO.OleObject openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   OLE Object Application
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
  ///   OLE Object Shape
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
  ///   OLE Object Unique ID
  /// </summary>
  [DataMember]
  public String? ObjectId
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.ObjectId);
    }
    set
    {
      _ExistingElement.ObjectId = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Relationship
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
  ///   Embedded Object Alternate Image Request.
  /// </summary>
  [DataMember]
  public DMVML.LinkType? LinkType
  {
    get
    {
      return _Element?.GetObject<DMVML.LinkType,DXVO.LinkType>();
    }
    set
    {
      _ExistingElement.SetObject<DMVML.LinkType,DXVO.LinkType>(value);
    }
  }
  
  
  /// <summary>
  ///   Embedded Object Cannot Be Refreshed.
  /// </summary>
  [DataMember]
  public DMVML.LockedField? LockedField
  {
    get
    {
      return _Element?.GetObject<DMVML.LockedField,DXVO.LockedField>();
    }
    set
    {
      _ExistingElement.SetObject<DMVML.LockedField,DXVO.LockedField>(value);
    }
  }
  
  
  /// <summary>
  ///   WordprocessingML Field Switches.
  /// </summary>
  [DataMember]
  public DMVML.FieldCodes? FieldCodes
  {
    get
    {
      return _Element?.GetObject<DMVML.FieldCodes,DXVO.FieldCodes>();
    }
    set
    {
      _ExistingElement.SetObject<DMVML.FieldCodes,DXVO.FieldCodes>(value);
    }
  }
  
}
