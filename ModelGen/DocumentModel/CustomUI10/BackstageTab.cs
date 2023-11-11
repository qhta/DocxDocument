namespace DocumentModel.CustomUI10;


/// <summary>
///   Defines the BackstageTab Class.
/// </summary>
public partial class BackstageTab: ModelElement<DXO10CUI.BackstageTab>
{
  public BackstageTab(): base(){ }
  
  public BackstageTab(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BackstageTab(DXO10CUI.BackstageTab openXmlElement): base(openXmlElement) { }
  
  
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
        _ExistingElement.Enabled = new DX.BooleanValue { Value = (Boolean)value };
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
  ///   title, this property is only available in Office 2010 and later.
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
  ///   getTitle, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? GetTitle
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.GetTitle);
    }
    set
    {
      _ExistingElement.GetTitle = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   columnWidthPercent, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int64? ColumnWidthPercent
  {
    get
    {
      return _Element?.ColumnWidthPercent?.Value;
    }
    set
    {
      _ExistingElement.ColumnWidthPercent = value;
    }
  }
  
  
  /// <summary>
  ///   firstColumnMinWidth, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int64? FirstColumnMinWidth
  {
    get
    {
      return _Element?.FirstColumnMinWidth?.Value;
    }
    set
    {
      _ExistingElement.FirstColumnMinWidth = value;
    }
  }
  
  
  /// <summary>
  ///   firstColumnMaxWidth, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int64? FirstColumnMaxWidth
  {
    get
    {
      return _Element?.FirstColumnMaxWidth?.Value;
    }
    set
    {
      _ExistingElement.FirstColumnMaxWidth = value;
    }
  }
  
  
  /// <summary>
  ///   secondColumnMinWidth, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int64? SecondColumnMinWidth
  {
    get
    {
      return _Element?.SecondColumnMinWidth?.Value;
    }
    set
    {
      _ExistingElement.SecondColumnMinWidth = value;
    }
  }
  
  
  /// <summary>
  ///   secondColumnMaxWidth, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int64? SecondColumnMaxWidth
  {
    get
    {
      return _Element?.SecondColumnMaxWidth?.Value;
    }
    set
    {
      _ExistingElement.SecondColumnMaxWidth = value;
    }
  }
  
  
  /// <summary>
  ///   BackstageGroups.
  /// </summary>
  [DataMember]
  public DMCUI10.BackstageGroups? BackstageGroups
  {
    get
    {
      return _Element?.GetObject<DMCUI10.BackstageGroups,DXO10CUI.BackstageGroups>();
    }
    set
    {
      _ExistingElement.SetObject<DMCUI10.BackstageGroups,DXO10CUI.BackstageGroups>(value);
    }
  }
  
  
  /// <summary>
  ///   SimpleGroups.
  /// </summary>
  [DataMember]
  public DMCUI10.SimpleGroups? SimpleGroups
  {
    get
    {
      return _Element?.GetObject<DMCUI10.SimpleGroups,DXO10CUI.SimpleGroups>();
    }
    set
    {
      _ExistingElement.SetObject<DMCUI10.SimpleGroups,DXO10CUI.SimpleGroups>(value);
    }
  }
  
}
