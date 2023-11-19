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
  public DocumentModel.HexInt? Id
  {
    get => HexIntConverter.GetValue(_Element?.Id);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   idQ, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? QualifiedId
  {
    get => HexIntConverter.GetValue(_Element?.QualifiedId);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   tag, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? Tag
  {
    get => _Element?.Tag;
    set => _ExistingElement.Tag = value;
  }
  
  
  /// <summary>
  ///   idMso, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? IdMso
  {
    get => _Element?.IdMso;
    set => _ExistingElement.IdMso = value;
  }
  
  
  /// <summary>
  ///   insertAfterMso, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? InsertAfterMso
  {
    get => _Element?.InsertAfterMso;
    set => _ExistingElement.InsertAfterMso = value;
  }
  
  
  /// <summary>
  ///   insertBeforeMso, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? InsertBeforeMso
  {
    get => _Element?.InsertBeforeMso;
    set => _ExistingElement.InsertBeforeMso = value;
  }
  
  
  /// <summary>
  ///   insertAfterQ, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? InsertAfterQulifiedId
  {
    get => HexIntConverter.GetValue(_Element?.InsertAfterQulifiedId);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   insertBeforeQ, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? InsertBeforeQulifiedId
  {
    get => HexIntConverter.GetValue(_Element?.InsertBeforeQulifiedId);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   enabled, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Boolean? Enabled
  {
    get => _Element?.Enabled?.Value;
    set => _ExistingElement.Enabled = value;
  }
  
  
  /// <summary>
  ///   getEnabled, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? GetEnabled
  {
    get => _Element?.GetEnabled;
    set => _ExistingElement.GetEnabled = value;
  }
  
  
  /// <summary>
  ///   label, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? Label
  {
    get => _Element?.Label;
    set => _ExistingElement.Label = value;
  }
  
  
  /// <summary>
  ///   getLabel, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? GetLabel
  {
    get => _Element?.GetLabel;
    set => _ExistingElement.GetLabel = value;
  }
  
  
  /// <summary>
  ///   visible, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Boolean? Visible
  {
    get => _Element?.Visible?.Value;
    set => _ExistingElement.Visible = value;
  }
  
  
  /// <summary>
  ///   getVisible, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? GetVisible
  {
    get => _Element?.GetVisible;
    set => _ExistingElement.GetVisible = value;
  }
  
  
  /// <summary>
  ///   keytip, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? Keytip
  {
    get => _Element?.Keytip;
    set => _ExistingElement.Keytip = value;
  }
  
  
  /// <summary>
  ///   getKeytip, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? GetKeytip
  {
    get => _Element?.GetKeytip;
    set => _ExistingElement.GetKeytip = value;
  }
  
  
  /// <summary>
  ///   title, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? Title
  {
    get => _Element?.Title;
    set => _ExistingElement.Title = value;
  }
  
  
  /// <summary>
  ///   getTitle, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? GetTitle
  {
    get => _Element?.GetTitle;
    set => _ExistingElement.GetTitle = value;
  }
  
  
  /// <summary>
  ///   columnWidthPercent, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int64? ColumnWidthPercent
  {
    get => _Element?.ColumnWidthPercent?.Value;
    set => _ExistingElement.ColumnWidthPercent = value;
  }
  
  
  /// <summary>
  ///   firstColumnMinWidth, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int64? FirstColumnMinWidth
  {
    get => _Element?.FirstColumnMinWidth?.Value;
    set => _ExistingElement.FirstColumnMinWidth = value;
  }
  
  
  /// <summary>
  ///   firstColumnMaxWidth, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int64? FirstColumnMaxWidth
  {
    get => _Element?.FirstColumnMaxWidth?.Value;
    set => _ExistingElement.FirstColumnMaxWidth = value;
  }
  
  
  /// <summary>
  ///   secondColumnMinWidth, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int64? SecondColumnMinWidth
  {
    get => _Element?.SecondColumnMinWidth?.Value;
    set => _ExistingElement.SecondColumnMinWidth = value;
  }
  
  
  /// <summary>
  ///   secondColumnMaxWidth, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int64? SecondColumnMaxWidth
  {
    get => _Element?.SecondColumnMaxWidth?.Value;
    set => _ExistingElement.SecondColumnMaxWidth = value;
  }
  
  
  /// <summary>
  ///   BackstageGroups.
  /// </summary>
  [DataMember]
  public DMCUI10.BackstageGroups? BackstageGroups
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   SimpleGroups.
  /// </summary>
  [DataMember]
  public DMCUI10.SimpleGroups? SimpleGroups
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
