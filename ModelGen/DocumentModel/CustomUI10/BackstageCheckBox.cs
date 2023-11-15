namespace DocumentModel.CustomUI10;


/// <summary>
///   Defines the BackstageCheckBox Class.
/// </summary>
public partial class BackstageCheckBox: ModelElement<DXO10CUI.BackstageCheckBox>
{
  public BackstageCheckBox(): base(){ }
  
  public BackstageCheckBox(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BackstageCheckBox(DXO10CUI.BackstageCheckBox openXmlElement): base(openXmlElement) { }
  
  
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
  ///   onAction, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? OnAction
  {
    get => _Element?.OnAction;
    set => _ExistingElement.OnAction = value;
  }
  
  
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
  
}
