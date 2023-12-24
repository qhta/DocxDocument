namespace DocumentModel.CustomUI10;


/// <summary>
///   Defines the RadioGroup Class.
/// </summary>
public partial class RadioGroup: ModelElement<DXO10CUI.RadioGroup>
{
  public RadioGroup(): base(){ }
  
  public RadioGroup(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public RadioGroup(DXO10CUI.RadioGroup openXmlElement): base(openXmlElement) { }
  
  
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
  ///   onAction, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? OnAction
  {
    get => _Element?.OnAction;
    set => _ExistingElement.OnAction = value;
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
  ///   getSelectedItemIndex, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? GetSelectedItemIndex
  {
    get => _Element?.GetSelectedItemIndex;
    set => _ExistingElement.GetSelectedItemIndex = value;
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
  public String? GetItemID
  {
    get => _Element?.GetItemID;
    set => _ExistingElement.GetItemID = value;
  }
  
}
