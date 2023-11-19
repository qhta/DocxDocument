namespace DocumentModel.CustomUI10;


/// <summary>
///   Defines the CheckBox Class.
/// </summary>
public partial class CheckBox: ModelElement<DXO10CUI.CheckBox>
{
  public CheckBox(): base(){ }
  
  public CheckBox(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CheckBox(DXO10CUI.CheckBox openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   getPressed, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? GetPressed
  {
    get => _Element?.GetPressed;
    set => _ExistingElement.GetPressed = value;
  }
  
  
  /// <summary>
  ///   onAction, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? OnAction
  {
    get => _Element?.OnAction;
    set => _ExistingElement.OnAction = value;
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
  ///   description, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? Description
  {
    get => _Element?.Description;
    set => _ExistingElement.Description = value;
  }
  
  
  /// <summary>
  ///   getDescription, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? GetDescription
  {
    get => _Element?.GetDescription;
    set => _ExistingElement.GetDescription = value;
  }
  
  
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
  ///   screentip, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? Screentip
  {
    get => _Element?.Screentip;
    set => _ExistingElement.Screentip = value;
  }
  
  
  /// <summary>
  ///   getScreentip, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? GetScreentip
  {
    get => _Element?.GetScreentip;
    set => _ExistingElement.GetScreentip = value;
  }
  
  
  /// <summary>
  ///   supertip, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? Supertip
  {
    get => _Element?.Supertip;
    set => _ExistingElement.Supertip = value;
  }
  
  
  /// <summary>
  ///   getSupertip, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? GetSupertip
  {
    get => _Element?.GetSupertip;
    set => _ExistingElement.GetSupertip = value;
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
  
}
