namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that an embedded object is located at this position in the run’s contents. The layout properties of this embedded object, as well as an optional static representation, are specified using the drawing element.
/// </summary>
public partial class EmbeddedObject: ModelElement<DXW.EmbeddedObject>
{
  public EmbeddedObject(): base(){ }
  
  public EmbeddedObject(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public EmbeddedObject(DXW.EmbeddedObject openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   dxaOrig
  /// </summary>
  [DataMember]
  public String? DxaOriginal
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.DxaOriginal);
    }
    set
    {
      _ExistingElement.DxaOriginal = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   dyaOrig
  /// </summary>
  [DataMember]
  public String? DyaOriginal
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.DyaOriginal);
    }
    set
    {
      _ExistingElement.DyaOriginal = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   anchorId, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public DM.HexBinary? AnchorId
  {
    get
    {
      if (_Element?.AnchorId?.Value != null)
        return HexIntConverter.GetValue(_ExistingElement.AnchorId.Value);
      return null;
    }
    set
    {
      if (value != null)
        _ExistingElement.AnchorId = value.ToString();
      else
        _ExistingElement.AnchorId = null;
    }
  }
  
  [DataMember]
  public DMW.Drawing? Drawing
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.Drawing>();
      if (element != null)
        return DrawingConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.Drawing>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DrawingConverter.CreateOpenXmlElement<DXW.Drawing>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.Control? Control
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.Control>();
      if (element != null)
        return ControlConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.Control>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ControlConverter.CreateOpenXmlElement<DXW.Control>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.ObjectEmbed? ObjectEmbed
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.ObjectEmbed>();
      if (element != null)
        return ObjectEmbedConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.ObjectEmbed>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ObjectEmbedConverter.CreateOpenXmlElement<DXW.ObjectEmbed>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.ObjectLink? ObjectLink
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.ObjectLink>();
      if (element != null)
        return ObjectLinkConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.ObjectLink>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ObjectLinkConverter.CreateOpenXmlElement<DXW.ObjectLink>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
