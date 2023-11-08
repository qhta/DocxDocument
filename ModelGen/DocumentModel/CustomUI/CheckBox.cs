namespace DocumentModel.CustomUI;


/// <summary>
///   Defines the CheckBox Class.
/// </summary>
public partial class CheckBox: ModelElement<DXOCUI.CheckBox>
{
  public CheckBox(): base(){ }
  
  public CheckBox(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CheckBox(DXOCUI.CheckBox openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   getPressed
  /// </summary>
  [DataMember]
  public String? GetPressed
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.GetPressed);
    }
    set
    {
      _ExistingElement.GetPressed = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   onAction
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
  ///   description
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
  ///   getDescription
  /// </summary>
  [DataMember]
  public String? GetDescription
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.GetDescription);
    }
    set
    {
      _ExistingElement.GetDescription = StringValueConverter.CreateStringValue(value);
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
  ///   screentip
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
  ///   getScreentip
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
  ///   supertip
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
  ///   getSupertip
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
  ///   label
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
  ///   getLabel
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
  
}
