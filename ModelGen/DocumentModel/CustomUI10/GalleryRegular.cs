namespace DocumentModel.CustomUI10;


/// <summary>
///   Defines the GalleryRegular Class.
/// </summary>
public partial class GalleryRegular: ModelElement<DXO10CUI.GalleryRegular>
{
  public GalleryRegular(): base(){ }
  
  public GalleryRegular(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GalleryRegular(DXO10CUI.GalleryRegular openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   description, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? Description
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Description);
    }
    set
    {
      _ExistingElement.Description = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   getDescription, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? GetDescription
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.GetDescription);
    }
    set
    {
      _ExistingElement.GetDescription = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   invalidateContentOnDrop, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Boolean? InvalidateContentOnDrop
  {
    get
    {
      return _Element?.InvalidateContentOnDrop?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.InvalidateContentOnDrop = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.InvalidateContentOnDrop = null;
    }
  }
  
  
  /// <summary>
  ///   columns, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int64? Columns
  {
    get
    {
      return _Element?.Columns?.Value;
    }
    set
    {
      _ExistingElement.Columns = value;
    }
  }
  
  
  /// <summary>
  ///   rows, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int64? Rows
  {
    get
    {
      return _Element?.Rows?.Value;
    }
    set
    {
      _ExistingElement.Rows = value;
    }
  }
  
  
  /// <summary>
  ///   itemWidth, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int64? ItemWidth
  {
    get
    {
      return _Element?.ItemWidth?.Value;
    }
    set
    {
      _ExistingElement.ItemWidth = value;
    }
  }
  
  
  /// <summary>
  ///   itemHeight, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int64? ItemHeight
  {
    get
    {
      return _Element?.ItemHeight?.Value;
    }
    set
    {
      _ExistingElement.ItemHeight = value;
    }
  }
  
  
  /// <summary>
  ///   getItemWidth, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? GetItemWidth
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.GetItemWidth);
    }
    set
    {
      _ExistingElement.GetItemWidth = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   getItemHeight, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? GetItemHeight
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.GetItemHeight);
    }
    set
    {
      _ExistingElement.GetItemHeight = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   showItemLabel, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Boolean? ShowItemLabel
  {
    get
    {
      return _Element?.ShowItemLabel?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.ShowItemLabel = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.ShowItemLabel = null;
    }
  }
  
  
  /// <summary>
  ///   onAction, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? OnAction
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.OnAction);
    }
    set
    {
      _ExistingElement.OnAction = StringValueConverter.CreateStringValue(value);
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
        _ExistingElement.Enabled = new BooleanValue { Value = (Boolean)value };
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
  ///   image, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? Image
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Image);
    }
    set
    {
      _ExistingElement.Image = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   imageMso, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? ImageMso
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.ImageMso);
    }
    set
    {
      _ExistingElement.ImageMso = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   getImage, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? GetImage
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.GetImage);
    }
    set
    {
      _ExistingElement.GetImage = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   showItemImage, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Boolean? ShowItemImage
  {
    get
    {
      return _Element?.ShowItemImage?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.ShowItemImage = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.ShowItemImage = null;
    }
  }
  
  
  /// <summary>
  ///   getItemCount, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? GetItemCount
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.GetItemCount);
    }
    set
    {
      _ExistingElement.GetItemCount = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   getItemLabel, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? GetItemLabel
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.GetItemLabel);
    }
    set
    {
      _ExistingElement.GetItemLabel = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   getItemScreentip, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? GetItemScreentip
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.GetItemScreentip);
    }
    set
    {
      _ExistingElement.GetItemScreentip = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   getItemSupertip, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? GetItemSupertip
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.GetItemSupertip);
    }
    set
    {
      _ExistingElement.GetItemSupertip = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   getItemImage, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? GetItemImage
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.GetItemImage);
    }
    set
    {
      _ExistingElement.GetItemImage = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   getItemID, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? GetItemID
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.GetItemID);
    }
    set
    {
      _ExistingElement.GetItemID = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   sizeString, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? SizeString
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.SizeString);
    }
    set
    {
      _ExistingElement.SizeString = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   getSelectedItemID, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? GetSelectedItemID
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.GetSelectedItemID);
    }
    set
    {
      _ExistingElement.GetSelectedItemID = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   getSelectedItemIndex, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? GetSelectedItemIndex
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.GetSelectedItemIndex);
    }
    set
    {
      _ExistingElement.GetSelectedItemIndex = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
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
  ///   screentip, this property is only available in Office 2010 and later.
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
  ///   getScreentip, this property is only available in Office 2010 and later.
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
  ///   supertip, this property is only available in Office 2010 and later.
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
  ///   getSupertip, this property is only available in Office 2010 and later.
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
        _ExistingElement.Visible = new BooleanValue { Value = (Boolean)value };
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
  ///   showLabel, this property is only available in Office 2010 and later.
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
        _ExistingElement.ShowLabel = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.ShowLabel = null;
    }
  }
  
  
  /// <summary>
  ///   getShowLabel, this property is only available in Office 2010 and later.
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
  
  
  /// <summary>
  ///   showImage, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Boolean? ShowImage
  {
    get
    {
      return _Element?.ShowImage?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.ShowImage = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.ShowImage = null;
    }
  }
  
  
  /// <summary>
  ///   getShowImage, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? GetShowImage
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.GetShowImage);
    }
    set
    {
      _ExistingElement.GetShowImage = StringValueConverter.CreateStringValue(value);
    }
  }
  
}
