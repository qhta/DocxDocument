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
        return HexIntConverter.GetValue(_Element?.AnchorId.Value);
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
      return _Element?.GetObject<DMW.Drawing,DXW.Drawing>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.Drawing,DXW.Drawing>(value);
    }
  }
  
  [DataMember]
  public DMW.Control? Control
  {
    get
    {
      return _Element?.GetObject<DMW.Control,DXW.Control>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.Control,DXW.Control>(value);
    }
  }
  
  [DataMember]
  public DMW.ObjectEmbed? ObjectEmbed
  {
    get
    {
      return _Element?.GetObject<DMW.ObjectEmbed,DXW.ObjectEmbed>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.ObjectEmbed,DXW.ObjectEmbed>(value);
    }
  }
  
  [DataMember]
  public DMW.ObjectLink? ObjectLink
  {
    get
    {
      return _Element?.GetObject<DMW.ObjectLink,DXW.ObjectLink>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.ObjectLink,DXW.ObjectLink>(value);
    }
  }
  
}
