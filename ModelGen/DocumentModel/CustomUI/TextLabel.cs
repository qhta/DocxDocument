namespace DocumentModel.CustomUI;


/// <summary>
///   Defines the TextLabel Class.
/// </summary>
public partial class TextLabel: ModelElement<DXOCUI.TextLabel>
{
  public TextLabel(): base(){ }
  
  public TextLabel(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TextLabel(DXOCUI.TextLabel openXmlElement): base(openXmlElement) { }
  
  
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
        _ExistingElement.Enabled = new DX.BooleanValue { Value = (Boolean)value };
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
        _ExistingElement.Visible = new DX.BooleanValue { Value = (Boolean)value };
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
        _ExistingElement.ShowLabel = new DX.BooleanValue { Value = (Boolean)value };
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
  
}
