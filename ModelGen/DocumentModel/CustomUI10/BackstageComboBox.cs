namespace DocumentModel.CustomUI10;


/// <summary>
///   Defines the BackstageComboBox Class.
/// </summary>
public partial class BackstageComboBox: ModelElement<DXO10CUI.BackstageComboBox>
{
  public BackstageComboBox(): base(){ }
  
  public BackstageComboBox(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BackstageComboBox(DXO10CUI.BackstageComboBox openXmlElement): base(openXmlElement) { }
  
  
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
  ///   getText, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? GetText
  {
    get => _Element?.GetText;
    set => _ExistingElement.GetText = value;
  }
  
  
  /// <summary>
  ///   onChange, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? OnChange
  {
    get => _Element?.OnChange;
    set => _ExistingElement.OnChange = value;
  }
  
  
  /// <summary>
  ///   sizeString, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? SizeString
  {
    get => _Element?.SizeString;
    set => _ExistingElement.SizeString = value;
  }
  
  
  /// <summary>
  ///   getItemCount, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? GetItemCount
  {
    get => _Element?.GetItemCount;
    set => _ExistingElement.GetItemCount = value;
  }
  
  
  /// <summary>
  ///   getItemLabel, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? GetItemLabel
  {
    get => _Element?.GetItemLabel;
    set => _ExistingElement.GetItemLabel = value;
  }
  
  
  /// <summary>
  ///   getItemID, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? GetItemID
  {
    get => HexIntConverter.GetValue(_Element?.GetItemID);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
}
