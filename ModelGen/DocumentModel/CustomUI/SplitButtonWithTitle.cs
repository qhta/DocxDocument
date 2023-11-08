namespace DocumentModel.CustomUI;


/// <summary>
///   Defines the SplitButtonWithTitle Class.
/// </summary>
public partial class SplitButtonWithTitle: ModelElement<DXOCUI.SplitButtonWithTitle>
{
  public SplitButtonWithTitle(): base(){ }
  
  public SplitButtonWithTitle(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SplitButtonWithTitle(DXOCUI.SplitButtonWithTitle openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   enabled
  /// </summary>
  [DataMember]
  public Boolean? Enabled
  {
    get
    {
      return _Element?.Enabled?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Enabled = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.Enabled = null;
    }
  }
  
  
  /// <summary>
  ///   getEnabled
  /// </summary>
  [DataMember]
  public String? GetEnabled
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.GetEnabled);
    }
    set
    {
      _ExistingElement.GetEnabled = StringValueConverter.CreateStringValue(value);
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
  ///   idQ
  /// </summary>
  [DataMember]
  public String? IdQ
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.IdQ);
    }
    set
    {
      _ExistingElement.IdQ = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   idMso
  /// </summary>
  [DataMember]
  public String? IdMso
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.IdMso);
    }
    set
    {
      _ExistingElement.IdMso = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   tag
  /// </summary>
  [DataMember]
  public String? Tag
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Tag);
    }
    set
    {
      _ExistingElement.Tag = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   insertAfterMso
  /// </summary>
  [DataMember]
  public String? InsertAfterMso
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.InsertAfterMso);
    }
    set
    {
      _ExistingElement.InsertAfterMso = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   insertBeforeMso
  /// </summary>
  [DataMember]
  public String? InsertBeforeMso
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.InsertBeforeMso);
    }
    set
    {
      _ExistingElement.InsertBeforeMso = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   insertAfterQ
  /// </summary>
  [DataMember]
  public String? InsertAfterQ
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.InsertAfterQ);
    }
    set
    {
      _ExistingElement.InsertAfterQ = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   insertBeforeQ
  /// </summary>
  [DataMember]
  public String? InsertBeforeQ
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.InsertBeforeQ);
    }
    set
    {
      _ExistingElement.InsertBeforeQ = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   visible
  /// </summary>
  [DataMember]
  public Boolean? Visible
  {
    get
    {
      return _Element?.Visible?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Visible = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.Visible = null;
    }
  }
  
  
  /// <summary>
  ///   getVisible
  /// </summary>
  [DataMember]
  public String? GetVisible
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.GetVisible);
    }
    set
    {
      _ExistingElement.GetVisible = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   keytip
  /// </summary>
  [DataMember]
  public String? Keytip
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Keytip);
    }
    set
    {
      _ExistingElement.Keytip = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   getKeytip
  /// </summary>
  [DataMember]
  public String? GetKeytip
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.GetKeytip);
    }
    set
    {
      _ExistingElement.GetKeytip = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   showLabel
  /// </summary>
  [DataMember]
  public Boolean? ShowLabel
  {
    get
    {
      return _Element?.ShowLabel?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.ShowLabel = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.ShowLabel = null;
    }
  }
  
  
  /// <summary>
  ///   getShowLabel
  /// </summary>
  [DataMember]
  public String? GetShowLabel
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.GetShowLabel);
    }
    set
    {
      _ExistingElement.GetShowLabel = StringValueConverter.CreateStringValue(value);
    }
  }
  
  [DataMember]
  public DMCUI.VisibleButton? VisibleButton
  {
    get
    {
      var element = _Element?.GetFirstChild<DXOCUI.VisibleButton>();
      if (element != null)
        return VisibleButtonConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXOCUI.VisibleButton>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = VisibleButtonConverter.CreateOpenXmlElement<DXOCUI.VisibleButton>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMCUI.VisibleToggleButton? VisibleToggleButton
  {
    get
    {
      var element = _Element?.GetFirstChild<DXOCUI.VisibleToggleButton>();
      if (element != null)
        return VisibleToggleButtonConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXOCUI.VisibleToggleButton>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = VisibleToggleButtonConverter.CreateOpenXmlElement<DXOCUI.VisibleToggleButton>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMCUI.MenuWithTitle? MenuWithTitle
  {
    get
    {
      var element = _Element?.GetFirstChild<DXOCUI.MenuWithTitle>();
      if (element != null)
        return MenuWithTitleConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXOCUI.MenuWithTitle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MenuWithTitleConverter.CreateOpenXmlElement<DXOCUI.MenuWithTitle>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
