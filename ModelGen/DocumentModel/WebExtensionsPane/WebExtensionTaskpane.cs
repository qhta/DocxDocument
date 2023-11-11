namespace DocumentModel.WebExtensionsPane;


/// <summary>
///   Defines the WebExtensionTaskpane Class.
/// </summary>
public partial class WebExtensionTaskpane: ModelElement<DXO13WEP.WebExtensionTaskpane>
{
  public WebExtensionTaskpane(): base(){ }
  
  public WebExtensionTaskpane(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public WebExtensionTaskpane(DXO13WEP.WebExtensionTaskpane openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   dockstate, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public String? DockState
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.DockState);
    }
    set
    {
      _ExistingElement.DockState = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   visibility, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public Boolean? Visibility
  {
    get
    {
      return _Element?.Visibility?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Visibility = new DX.BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.Visibility = null;
    }
  }
  
  
  /// <summary>
  ///   width, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public Double? Width
  {
    get
    {
      return _Element?.Width?.Value;
    }
    set
    {
      _ExistingElement.Width = value;
    }
  }
  
  
  /// <summary>
  ///   row, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public UInt32? Row
  {
    get
    {
      return _Element?.Row?.Value;
    }
    set
    {
      _ExistingElement.Row = value;
    }
  }
  
  
  /// <summary>
  ///   locked, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public Boolean? Locked
  {
    get
    {
      return _Element?.Locked?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Locked = new DX.BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.Locked = null;
    }
  }
  
  
  /// <summary>
  ///   WebExtensionPartReference.
  /// </summary>
  [DataMember]
  public DMWEP.WebExtensionPartReference? WebExtensionPartReference
  {
    get
    {
      return _Element?.GetObject<DMWEP.WebExtensionPartReference,DXO13WEP.WebExtensionPartReference>();
    }
    set
    {
      _ExistingElement.SetObject<DMWEP.WebExtensionPartReference,DXO13WEP.WebExtensionPartReference>(value);
    }
  }
  
  
  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  [DataMember]
  public DMWEP.OfficeArtExtensionList? OfficeArtExtensionList
  {
    get
    {
      return _Element?.GetObject<DMWEP.OfficeArtExtensionList,DXO13WEP.OfficeArtExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMWEP.OfficeArtExtensionList,DXO13WEP.OfficeArtExtensionList>(value);
    }
  }
  
}
