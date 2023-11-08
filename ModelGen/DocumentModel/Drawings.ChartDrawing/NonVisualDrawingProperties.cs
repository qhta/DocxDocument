namespace DocumentModel.Drawings.ChartDrawing;


/// <summary>
///   Chart Non Visual Properties.
/// </summary>
public partial class NonVisualDrawingProperties: ModelElement<DXDCD.NonVisualDrawingProperties>
{
  public NonVisualDrawingProperties(): base(){ }
  
  public NonVisualDrawingProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NonVisualDrawingProperties(DXDCD.NonVisualDrawingProperties openXmlElement): base(openXmlElement) { }
  
  
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
        _ExistingElement.Hidden = new BooleanValue { Value = (Boolean)value };
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
      var element = _Element?.GetFirstChild<DXD.HyperlinkOnClick>();
      if (element != null)
        return HyperlinkOnClickConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.HyperlinkOnClick>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HyperlinkOnClickConverter.CreateOpenXmlElement<DXD.HyperlinkOnClick>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXD.HyperlinkOnHover>();
      if (element != null)
        return HyperlinkOnHoverConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.HyperlinkOnHover>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HyperlinkOnHoverConverter.CreateOpenXmlElement<DXD.HyperlinkOnHover>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXD.NonVisualDrawingPropertiesExtensionList>();
      if (element != null)
        return NonVisualDrawingPropertiesExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.NonVisualDrawingPropertiesExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NonVisualDrawingPropertiesExtensionListConverter.CreateOpenXmlElement<DXD.NonVisualDrawingPropertiesExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
