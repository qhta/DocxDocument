namespace DocumentModel.Drawings;


/// <summary>
///   Defines the HyperlinkType Class.
/// </summary>
public partial class HyperlinkType: ModelElement<DXD.HyperlinkType>
{
  public HyperlinkType(): base(){ }
  
  public HyperlinkType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public HyperlinkType(DXD.HyperlinkType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   relationship identifier to find target URI
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
  ///   In case the url is invalid so we can't create a relationship, we'll save it here, r:id will point to a NULL one
  /// </summary>
  [DataMember]
  public String? InvalidUrl
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.InvalidUrl);
    }
    set
    {
      _ExistingElement.InvalidUrl = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Action to take, it may still need r:id to specify an action target
  /// </summary>
  [DataMember]
  public String? Action
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Action);
    }
    set
    {
      _ExistingElement.Action = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   target frame for navigating to the URI
  /// </summary>
  [DataMember]
  public String? TargetFrame
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.TargetFrame);
    }
    set
    {
      _ExistingElement.TargetFrame = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   tooltip for display
  /// </summary>
  [DataMember]
  public String? Tooltip
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Tooltip);
    }
    set
    {
      _ExistingElement.Tooltip = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   whether to add this URI to the history when navigating to it
  /// </summary>
  [DataMember]
  public Boolean? History
  {
    get
    {
      return _Element?.History?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.History = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.History = null;
    }
  }
  
  
  /// <summary>
  ///   Whether to highlight it when click on a shape
  /// </summary>
  [DataMember]
  public Boolean? HighlightClick
  {
    get
    {
      return _Element?.HighlightClick?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.HighlightClick = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.HighlightClick = null;
    }
  }
  
  
  /// <summary>
  ///   Whether to stop previous sound when click on it
  /// </summary>
  [DataMember]
  public Boolean? EndSound
  {
    get
    {
      return _Element?.EndSound?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.EndSound = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.EndSound = null;
    }
  }
  
  
  /// <summary>
  ///   Sound to play..
  /// </summary>
  [DataMember]
  public DMD.HyperlinkSound? HyperlinkSound
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.HyperlinkSound>();
      if (element != null)
        return HyperlinkSoundConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.HyperlinkSound>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HyperlinkSoundConverter.CreateOpenXmlElement<DXD.HyperlinkSound>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Future extensions..
  /// </summary>
  [DataMember]
  public DMD.HyperlinkExtensionList? HyperlinkExtensionList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.HyperlinkExtensionList>();
      if (element != null)
        return HyperlinkExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.HyperlinkExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HyperlinkExtensionListConverter.CreateOpenXmlElement<DXD.HyperlinkExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
