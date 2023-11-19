namespace DocumentModel.CustomUI10;


/// <summary>
///   Defines the Gallery Class.
/// </summary>
public partial class Gallery: ModelElement<DXO10CUI.Gallery>
{
  public Gallery(): base(){ }
  
  public Gallery(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Gallery(DXO10CUI.Gallery openXmlElement): base(openXmlElement) { }
  
  
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
  ///   invalidateContentOnDrop, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Boolean? InvalidateContentOnDrop
  {
    get => _Element?.InvalidateContentOnDrop?.Value;
    set => _ExistingElement.InvalidateContentOnDrop = value;
  }
  
  
  /// <summary>
  ///   columns, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int64? Columns
  {
    get => _Element?.Columns?.Value;
    set => _ExistingElement.Columns = value;
  }
  
  
  /// <summary>
  ///   rows, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int64? Rows
  {
    get => _Element?.Rows?.Value;
    set => _ExistingElement.Rows = value;
  }
  
  
  /// <summary>
  ///   itemWidth, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int64? ItemWidth
  {
    get => _Element?.ItemWidth?.Value;
    set => _ExistingElement.ItemWidth = value;
  }
  
  
  /// <summary>
  ///   itemHeight, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int64? ItemHeight
  {
    get => _Element?.ItemHeight?.Value;
    set => _ExistingElement.ItemHeight = value;
  }
  
  
  /// <summary>
  ///   getItemWidth, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? GetItemWidth
  {
    get => _Element?.GetItemWidth;
    set => _ExistingElement.GetItemWidth = value;
  }
  
  
  /// <summary>
  ///   getItemHeight, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? GetItemHeight
  {
    get => _Element?.GetItemHeight;
    set => _ExistingElement.GetItemHeight = value;
  }
  
  
  /// <summary>
  ///   showItemLabel, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Boolean? ShowItemLabel
  {
    get => _Element?.ShowItemLabel?.Value;
    set => _ExistingElement.ShowItemLabel = value;
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
  ///   image, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? Image
  {
    get => _Element?.Image;
    set => _ExistingElement.Image = value;
  }
  
  
  /// <summary>
  ///   imageMso, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? ImageMso
  {
    get => _Element?.ImageMso;
    set => _ExistingElement.ImageMso = value;
  }
  
  
  /// <summary>
  ///   getImage, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? GetImage
  {
    get => _Element?.GetImage;
    set => _ExistingElement.GetImage = value;
  }
  
  
  /// <summary>
  ///   showItemImage, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Boolean? ShowItemImage
  {
    get => _Element?.ShowItemImage?.Value;
    set => _ExistingElement.ShowItemImage = value;
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
  ///   getItemScreentip, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? GetItemScreentip
  {
    get => _Element?.GetItemScreentip;
    set => _ExistingElement.GetItemScreentip = value;
  }
  
  
  /// <summary>
  ///   getItemSupertip, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? GetItemSupertip
  {
    get => _Element?.GetItemSupertip;
    set => _ExistingElement.GetItemSupertip = value;
  }
  
  
  /// <summary>
  ///   getItemImage, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? GetItemImage
  {
    get => _Element?.GetItemImage;
    set => _ExistingElement.GetItemImage = value;
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
  ///   getSelectedItemID, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? GetSelectedItemID
  {
    get => HexIntConverter.GetValue(_Element?.GetSelectedItemID);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
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
  
  
  /// <summary>
  ///   showImage, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Boolean? ShowImage
  {
    get => _Element?.ShowImage?.Value;
    set => _ExistingElement.ShowImage = value;
  }
  
  
  /// <summary>
  ///   getShowImage, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? GetShowImage
  {
    get => _Element?.GetShowImage;
    set => _ExistingElement.GetShowImage = value;
  }
  
}
