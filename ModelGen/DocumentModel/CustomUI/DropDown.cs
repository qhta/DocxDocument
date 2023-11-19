namespace DocumentModel.CustomUI;


/// <summary>
///   Defines the DropDown Class.
/// </summary>
public partial class DropDown: ModelElement<DXOCUI.DropDown>
{
  public DropDown(): base(){ }
  
  public DropDown(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DropDown(DXOCUI.DropDown openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   onAction
  /// </summary>
  [DataMember]
  public String? OnAction
  {
    get => _Element?.OnAction;
    set => _ExistingElement.OnAction = value;
  }
  
  
  /// <summary>
  ///   enabled
  /// </summary>
  [DataMember]
  public Boolean? Enabled
  {
    get => _Element?.Enabled?.Value;
    set => _ExistingElement.Enabled = value;
  }
  
  
  /// <summary>
  ///   getEnabled
  /// </summary>
  [DataMember]
  public String? GetEnabled
  {
    get => _Element?.GetEnabled;
    set => _ExistingElement.GetEnabled = value;
  }
  
  
  /// <summary>
  ///   image
  /// </summary>
  [DataMember]
  public String? Image
  {
    get => _Element?.Image;
    set => _ExistingElement.Image = value;
  }
  
  
  /// <summary>
  ///   imageMso
  /// </summary>
  [DataMember]
  public String? ImageMso
  {
    get => _Element?.ImageMso;
    set => _ExistingElement.ImageMso = value;
  }
  
  
  /// <summary>
  ///   getImage
  /// </summary>
  [DataMember]
  public String? GetImage
  {
    get => _Element?.GetImage;
    set => _ExistingElement.GetImage = value;
  }
  
  
  /// <summary>
  ///   showItemImage
  /// </summary>
  [DataMember]
  public Boolean? ShowItemImage
  {
    get => _Element?.ShowItemImage?.Value;
    set => _ExistingElement.ShowItemImage = value;
  }
  
  
  /// <summary>
  ///   getItemCount
  /// </summary>
  [DataMember]
  public String? GetItemCount
  {
    get => _Element?.GetItemCount;
    set => _ExistingElement.GetItemCount = value;
  }
  
  
  /// <summary>
  ///   getItemLabel
  /// </summary>
  [DataMember]
  public String? GetItemLabel
  {
    get => _Element?.GetItemLabel;
    set => _ExistingElement.GetItemLabel = value;
  }
  
  
  /// <summary>
  ///   getItemScreentip
  /// </summary>
  [DataMember]
  public String? GetItemScreentip
  {
    get => _Element?.GetItemScreentip;
    set => _ExistingElement.GetItemScreentip = value;
  }
  
  
  /// <summary>
  ///   getItemSupertip
  /// </summary>
  [DataMember]
  public String? GetItemSupertip
  {
    get => _Element?.GetItemSupertip;
    set => _ExistingElement.GetItemSupertip = value;
  }
  
  
  /// <summary>
  ///   getItemImage
  /// </summary>
  [DataMember]
  public String? GetItemImage
  {
    get => _Element?.GetItemImage;
    set => _ExistingElement.GetItemImage = value;
  }
  
  
  /// <summary>
  ///   getItemID
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? GetItemID
  {
    get => HexIntConverter.GetValue(_Element?.GetItemID);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   sizeString
  /// </summary>
  [DataMember]
  public String? SizeString
  {
    get => _Element?.SizeString;
    set => _ExistingElement.SizeString = value;
  }
  
  
  /// <summary>
  ///   getSelectedItemID
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? GetSelectedItemID
  {
    get => HexIntConverter.GetValue(_Element?.GetSelectedItemID);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   getSelectedItemIndex
  /// </summary>
  [DataMember]
  public String? GetSelectedItemIndex
  {
    get => _Element?.GetSelectedItemIndex;
    set => _ExistingElement.GetSelectedItemIndex = value;
  }
  
  
  /// <summary>
  ///   showItemLabel
  /// </summary>
  [DataMember]
  public Boolean? ShowItemLabel
  {
    get => _Element?.ShowItemLabel?.Value;
    set => _ExistingElement.ShowItemLabel = value;
  }
  
  
  /// <summary>
  ///   id
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? Id
  {
    get => HexIntConverter.GetValue(_Element?.Id);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   idQ
  /// </summary>
  [DataMember]
  public String? IdQ
  {
    get => _Element?.IdQ;
    set => _ExistingElement.IdQ = value;
  }
  
  
  /// <summary>
  ///   idMso
  /// </summary>
  [DataMember]
  public String? IdMso
  {
    get => _Element?.IdMso;
    set => _ExistingElement.IdMso = value;
  }
  
  
  /// <summary>
  ///   tag
  /// </summary>
  [DataMember]
  public String? Tag
  {
    get => _Element?.Tag;
    set => _ExistingElement.Tag = value;
  }
  
  
  /// <summary>
  ///   screentip
  /// </summary>
  [DataMember]
  public String? Screentip
  {
    get => _Element?.Screentip;
    set => _ExistingElement.Screentip = value;
  }
  
  
  /// <summary>
  ///   getScreentip
  /// </summary>
  [DataMember]
  public String? GetScreentip
  {
    get => _Element?.GetScreentip;
    set => _ExistingElement.GetScreentip = value;
  }
  
  
  /// <summary>
  ///   supertip
  /// </summary>
  [DataMember]
  public String? Supertip
  {
    get => _Element?.Supertip;
    set => _ExistingElement.Supertip = value;
  }
  
  
  /// <summary>
  ///   getSupertip
  /// </summary>
  [DataMember]
  public String? GetSupertip
  {
    get => _Element?.GetSupertip;
    set => _ExistingElement.GetSupertip = value;
  }
  
  
  /// <summary>
  ///   label
  /// </summary>
  [DataMember]
  public String? Label
  {
    get => _Element?.Label;
    set => _ExistingElement.Label = value;
  }
  
  
  /// <summary>
  ///   getLabel
  /// </summary>
  [DataMember]
  public String? GetLabel
  {
    get => _Element?.GetLabel;
    set => _ExistingElement.GetLabel = value;
  }
  
  
  /// <summary>
  ///   insertAfterMso
  /// </summary>
  [DataMember]
  public String? InsertAfterMso
  {
    get => _Element?.InsertAfterMso;
    set => _ExistingElement.InsertAfterMso = value;
  }
  
  
  /// <summary>
  ///   insertBeforeMso
  /// </summary>
  [DataMember]
  public String? InsertBeforeMso
  {
    get => _Element?.InsertBeforeMso;
    set => _ExistingElement.InsertBeforeMso = value;
  }
  
  
  /// <summary>
  ///   insertAfterQ
  /// </summary>
  [DataMember]
  public String? InsertAfterQ
  {
    get => _Element?.InsertAfterQ;
    set => _ExistingElement.InsertAfterQ = value;
  }
  
  
  /// <summary>
  ///   insertBeforeQ
  /// </summary>
  [DataMember]
  public String? InsertBeforeQ
  {
    get => _Element?.InsertBeforeQ;
    set => _ExistingElement.InsertBeforeQ = value;
  }
  
  
  /// <summary>
  ///   visible
  /// </summary>
  [DataMember]
  public Boolean? Visible
  {
    get => _Element?.Visible?.Value;
    set => _ExistingElement.Visible = value;
  }
  
  
  /// <summary>
  ///   getVisible
  /// </summary>
  [DataMember]
  public String? GetVisible
  {
    get => _Element?.GetVisible;
    set => _ExistingElement.GetVisible = value;
  }
  
  
  /// <summary>
  ///   keytip
  /// </summary>
  [DataMember]
  public String? Keytip
  {
    get => _Element?.Keytip;
    set => _ExistingElement.Keytip = value;
  }
  
  
  /// <summary>
  ///   getKeytip
  /// </summary>
  [DataMember]
  public String? GetKeytip
  {
    get => _Element?.GetKeytip;
    set => _ExistingElement.GetKeytip = value;
  }
  
  
  /// <summary>
  ///   showLabel
  /// </summary>
  [DataMember]
  public Boolean? ShowLabel
  {
    get => _Element?.ShowLabel?.Value;
    set => _ExistingElement.ShowLabel = value;
  }
  
  
  /// <summary>
  ///   getShowLabel
  /// </summary>
  [DataMember]
  public String? GetShowLabel
  {
    get => _Element?.GetShowLabel;
    set => _ExistingElement.GetShowLabel = value;
  }
  
  
  /// <summary>
  ///   showImage
  /// </summary>
  [DataMember]
  public Boolean? ShowImage
  {
    get => _Element?.ShowImage?.Value;
    set => _ExistingElement.ShowImage = value;
  }
  
  
  /// <summary>
  ///   getShowImage
  /// </summary>
  [DataMember]
  public String? GetShowImage
  {
    get => _Element?.GetShowImage;
    set => _ExistingElement.GetShowImage = value;
  }
  
}
