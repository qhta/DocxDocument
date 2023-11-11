namespace DocumentModel.CustomUI10;


/// <summary>
///   Defines the BackstageGroup Class.
/// </summary>
public partial class BackstageGroup: ModelElement<DXO10CUI.BackstageGroup>
{
  public BackstageGroup(): base(){ }
  
  public BackstageGroup(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BackstageGroup(DXO10CUI.BackstageGroup openXmlElement): base(openXmlElement) { }
  
  
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
  ///   label, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? Label
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Label);
    }
    set
    {
      _ExistingElement.Label = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   getLabel, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? GetLabel
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.GetLabel);
    }
    set
    {
      _ExistingElement.GetLabel = StringValueConverter.CreateStringValue(value);
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
        _ExistingElement.Visible = new DX.BooleanValue { Value = (Boolean)value };
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
  ///   getStyle, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? GetStyle
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.GetStyle);
    }
    set
    {
      _ExistingElement.GetStyle = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   helperText, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? HelperText
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.HelperText);
    }
    set
    {
      _ExistingElement.HelperText = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   getHelperText, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? GetHelperText
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.GetHelperText);
    }
    set
    {
      _ExistingElement.GetHelperText = StringValueConverter.CreateStringValue(value);
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
        _ExistingElement.ShowLabel = new DX.BooleanValue { Value = (Boolean)value };
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
  public DMCUI10.PrimaryItem? PrimaryItem
  {
    get
    {
      return _Element?.GetObject<DMCUI10.PrimaryItem,DXO10CUI.PrimaryItem>();
    }
    set
    {
      _ExistingElement.SetObject<DMCUI10.PrimaryItem,DXO10CUI.PrimaryItem>(value);
    }
  }
  
  [DataMember]
  public DMCUI10.TopItemsGroupControls? TopItemsGroupControls
  {
    get
    {
      return _Element?.GetObject<DMCUI10.TopItemsGroupControls,DXO10CUI.TopItemsGroupControls>();
    }
    set
    {
      _ExistingElement.SetObject<DMCUI10.TopItemsGroupControls,DXO10CUI.TopItemsGroupControls>(value);
    }
  }
  
  [DataMember]
  public DMCUI10.BottomItemsGroupControls? BottomItemsGroupControls
  {
    get
    {
      return _Element?.GetObject<DMCUI10.BottomItemsGroupControls,DXO10CUI.BottomItemsGroupControls>();
    }
    set
    {
      _ExistingElement.SetObject<DMCUI10.BottomItemsGroupControls,DXO10CUI.BottomItemsGroupControls>(value);
    }
  }
  
}
