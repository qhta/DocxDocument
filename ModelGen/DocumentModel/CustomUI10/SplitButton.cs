namespace DocumentModel.CustomUI10;


/// <summary>
///   Defines the SplitButton Class.
/// </summary>
public partial class SplitButton: ModelElement<DXO10CUI.SplitButton>
{
  public SplitButton(): base(){ }
  
  public SplitButton(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SplitButton(DXO10CUI.SplitButton openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   getSize, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? GetSize
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.GetSize);
    }
    set
    {
      _ExistingElement.GetSize = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   enabled, this property is only available in Office 2010 and later.
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
  ///   getEnabled, this property is only available in Office 2010 and later.
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
  ///   id, this property is only available in Office 2010 and later.
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
  ///   idQ, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? QualifiedId
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.QualifiedId);
    }
    set
    {
      _ExistingElement.QualifiedId = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   tag, this property is only available in Office 2010 and later.
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
  ///   idMso, this property is only available in Office 2010 and later.
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
  ///   insertAfterMso, this property is only available in Office 2010 and later.
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
  ///   insertBeforeMso, this property is only available in Office 2010 and later.
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
  ///   insertAfterQ, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? InsertAfterQulifiedId
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.InsertAfterQulifiedId);
    }
    set
    {
      _ExistingElement.InsertAfterQulifiedId = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   insertBeforeQ, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? InsertBeforeQulifiedId
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.InsertBeforeQulifiedId);
    }
    set
    {
      _ExistingElement.InsertBeforeQulifiedId = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   visible, this property is only available in Office 2010 and later.
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
  ///   getVisible, this property is only available in Office 2010 and later.
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
  ///   keytip, this property is only available in Office 2010 and later.
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
  ///   getKeytip, this property is only available in Office 2010 and later.
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
  ///   showLabel, this property is only available in Office 2010 and later.
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
  ///   getShowLabel, this property is only available in Office 2010 and later.
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
  public DMCUI10.VisibleButton? VisibleButton
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10CUI.VisibleButton>();
      if (element != null)
        return VisibleButtonConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10CUI.VisibleButton>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = VisibleButtonConverter.CreateOpenXmlElement<DXO10CUI.VisibleButton>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMCUI10.VisibleToggleButton? VisibleToggleButton
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10CUI.VisibleToggleButton>();
      if (element != null)
        return VisibleToggleButtonConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10CUI.VisibleToggleButton>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = VisibleToggleButtonConverter.CreateOpenXmlElement<DXO10CUI.VisibleToggleButton>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMCUI10.MenuRegular? MenuRegular
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10CUI.MenuRegular>();
      if (element != null)
        return MenuRegularConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10CUI.MenuRegular>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MenuRegularConverter.CreateOpenXmlElement<DXO10CUI.MenuRegular>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
