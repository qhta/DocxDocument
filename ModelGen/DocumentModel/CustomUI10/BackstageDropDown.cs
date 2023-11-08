namespace DocumentModel.CustomUI10;


/// <summary>
///   Defines the BackstageDropDown Class.
/// </summary>
public partial class BackstageDropDown: ModelElement<DXO10CUI.BackstageDropDown>
{
  public BackstageDropDown(): base(){ }
  
  public BackstageDropDown(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BackstageDropDown(DXO10CUI.BackstageDropDown openXmlElement): base(openXmlElement) { }
  
  
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
  ///   onAction, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? OnAction
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.OnAction);
    }
    set
    {
      _ExistingElement.OnAction = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   screentip, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? Screentip
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Screentip);
    }
    set
    {
      _ExistingElement.Screentip = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   getScreentip, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? GetScreentip
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.GetScreentip);
    }
    set
    {
      _ExistingElement.GetScreentip = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   supertip, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? Supertip
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Supertip);
    }
    set
    {
      _ExistingElement.Supertip = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   getSupertip, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? GetSupertip
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.GetSupertip);
    }
    set
    {
      _ExistingElement.GetSupertip = StringValueConverter.CreateStringValue(value);
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
  ///   getSelectedItemIndex, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? GetSelectedItemIndex
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.GetSelectedItemIndex);
    }
    set
    {
      _ExistingElement.GetSelectedItemIndex = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   sizeString, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? SizeString
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.SizeString);
    }
    set
    {
      _ExistingElement.SizeString = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   getItemCount, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? GetItemCount
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.GetItemCount);
    }
    set
    {
      _ExistingElement.GetItemCount = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   getItemLabel, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? GetItemLabel
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.GetItemLabel);
    }
    set
    {
      _ExistingElement.GetItemLabel = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   getItemID, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? GetItemID
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.GetItemID);
    }
    set
    {
      _ExistingElement.GetItemID = StringValueConverter.CreateStringValue(value);
    }
  }
  
}
