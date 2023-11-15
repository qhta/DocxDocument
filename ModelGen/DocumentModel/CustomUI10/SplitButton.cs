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
    get => _Element?.GetSize;
    set => _ExistingElement.GetSize = value;
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
  ///   id, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? Id
  {
    get => _Element?.Id;
    set => _ExistingElement.Id = value;
  }
  
  
  /// <summary>
  ///   idQ, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? QualifiedId
  {
    get => _Element?.QualifiedId;
    set => _ExistingElement.QualifiedId = value;
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
  public String? InsertAfterQulifiedId
  {
    get => _Element?.InsertAfterQulifiedId;
    set => _ExistingElement.InsertAfterQulifiedId = value;
  }
  
  
  /// <summary>
  ///   insertBeforeQ, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? InsertBeforeQulifiedId
  {
    get => _Element?.InsertBeforeQulifiedId;
    set => _ExistingElement.InsertBeforeQulifiedId = value;
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
  ///   showLabel, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Boolean? ShowLabel
  {
    get => _Element?.ShowLabel?.Value;
    set => _ExistingElement.ShowLabel = value;
  }
  
  
  /// <summary>
  ///   getShowLabel, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? GetShowLabel
  {
    get => _Element?.GetShowLabel;
    set => _ExistingElement.GetShowLabel = value;
  }
  
  [DataMember]
  public DMCUI10.VisibleButton? VisibleButton
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  [DataMember]
  public DMCUI10.VisibleToggleButton? VisibleToggleButton
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  [DataMember]
  public DMCUI10.MenuRegular? MenuRegular
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
