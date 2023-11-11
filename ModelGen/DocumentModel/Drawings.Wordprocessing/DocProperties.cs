namespace DocumentModel.Drawings.Wordprocessing;


/// <summary>
///   Drawing Object Non-Visual Properties.
/// </summary>
public partial class DocProperties: ModelElement<DXDW.DocProperties>
{
  public DocProperties(): base(){ }
  
  public DocProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DocProperties(DXDW.DocProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Application defined unique identifier.
  /// </summary>
  [DataMember]
  public UInt32? Id
  {
    get
    {
      return _Element?.Id?.Value;
    }
    set
    {
      _ExistingElement.Id = value;
    }
  }
  
  
  /// <summary>
  ///   Name compatible with Object Model (non-unique).
  /// </summary>
  [DataMember]
  public String? Name
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Name);
    }
    set
    {
      _ExistingElement.Name = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Description of the drawing element.
  /// </summary>
  [DataMember]
  public String? Description
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Description);
    }
    set
    {
      _ExistingElement.Description = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Flag determining to show or hide this element.
  /// </summary>
  [DataMember]
  public Boolean? Hidden
  {
    get
    {
      return _Element?.Hidden?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Hidden = new DX.BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.Hidden = null;
    }
  }
  
  
  /// <summary>
  ///   Title
  /// </summary>
  [DataMember]
  public String? Title
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Title);
    }
    set
    {
      _ExistingElement.Title = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Hyperlink associated with clicking or selecting the element..
  /// </summary>
  [DataMember]
  public DMD.HyperlinkOnClick? HyperlinkOnClick
  {
    get
    {
      return _Element?.GetObject<DMD.HyperlinkOnClick,DXD.HyperlinkOnClick>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.HyperlinkOnClick,DXD.HyperlinkOnClick>(value);
    }
  }
  
  
  /// <summary>
  ///   Hyperlink associated with hovering over the element..
  /// </summary>
  [DataMember]
  public DMD.HyperlinkOnHover? HyperlinkOnHover
  {
    get
    {
      return _Element?.GetObject<DMD.HyperlinkOnHover,DXD.HyperlinkOnHover>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.HyperlinkOnHover,DXD.HyperlinkOnHover>(value);
    }
  }
  
  
  /// <summary>
  ///   Future extension.
  /// </summary>
  [DataMember]
  public DMD.NonVisualDrawingPropertiesExtensionList? NonVisualDrawingPropertiesExtensionList
  {
    get
    {
      return _Element?.GetObject<DMD.NonVisualDrawingPropertiesExtensionList,DXD.NonVisualDrawingPropertiesExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.NonVisualDrawingPropertiesExtensionList,DXD.NonVisualDrawingPropertiesExtensionList>(value);
    }
  }
  
}
