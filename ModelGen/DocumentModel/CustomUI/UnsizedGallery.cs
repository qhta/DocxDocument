namespace DocumentModel.CustomUI;


/// <summary>
///   Defines the UnsizedGallery Class.
/// </summary>
public partial class UnsizedGallery: ModelElement<DXOCUI.UnsizedGallery>
{
  public UnsizedGallery(): base(){ }
  
  public UnsizedGallery(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public UnsizedGallery(DXOCUI.UnsizedGallery openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   description
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
  ///   getDescription
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
  ///   invalidateContentOnDrop
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
  ///   columns
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
  ///   rows
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
  ///   itemWidth
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
  ///   itemHeight
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
  ///   getItemWidth
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
  ///   getItemHeight
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
  ///   showItemLabel
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
  ///   onAction
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
  ///   enabled
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
  ///   getEnabled
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
  ///   image
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
  ///   imageMso
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
  ///   getImage
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
  ///   showItemImage
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
  ///   getItemCount
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
  ///   getItemLabel
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
  ///   getItemScreentip
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
  ///   getItemSupertip
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
  ///   getItemImage
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
  ///   getItemID
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
  ///   sizeString
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
  ///   getSelectedItemID
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
  ///   getSelectedItemIndex
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
  ///   id
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
  ///   idQ
  /// </summary>
  [DataMember]
  public String? IdQ
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.IdQ);
    }
    set
    {
      _ExistingElement.IdQ = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   idMso
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
  ///   tag
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
  ///   screentip
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
  ///   getScreentip
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
  ///   supertip
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
  ///   getSupertip
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
  ///   label
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
  ///   getLabel
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
  ///   insertAfterMso
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
  ///   insertBeforeMso
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
  ///   insertAfterQ
  /// </summary>
  [DataMember]
  public String? InsertAfterQ
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.InsertAfterQ);
    }
    set
    {
      _ExistingElement.InsertAfterQ = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   insertBeforeQ
  /// </summary>
  [DataMember]
  public String? InsertBeforeQ
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.InsertBeforeQ);
    }
    set
    {
      _ExistingElement.InsertBeforeQ = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   visible
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
  ///   getVisible
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
  ///   keytip
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
  ///   getKeytip
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
  ///   showLabel
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
  ///   getShowLabel
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
  ///   showImage
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
  ///   getShowImage
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
