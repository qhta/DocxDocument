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
      var element = _Element?.GetFirstChild<DXVO.LinkType>();
      if (element != null)
        return LinkTypeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXVO.LinkType>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LinkTypeConverter.CreateOpenXmlElement<DXVO.LinkType>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXVO.LockedField>();
      if (element != null)
        return LockedFieldConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXVO.LockedField>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LockedFieldConverter.CreateOpenXmlElement<DXVO.LockedField>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXVO.FieldCodes>();
      if (element != null)
        return FieldCodesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXVO.FieldCodes>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FieldCodesConverter.CreateOpenXmlElement<DXVO.FieldCodes>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
