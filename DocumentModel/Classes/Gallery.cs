namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the Gallery Class.
/// </summary>
public class Gallery: ModelElement
{
  /// <summary>
  ///   size, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public SizeKind? Size { get; set; }

  /// <summary>
  ///   getSize, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? GetSize { get; set; }

  /// <summary>
  ///   description, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? Description { get; set; }

  /// <summary>
  ///   getDescription, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? GetDescription { get; set; }

  /// <summary>
  ///   invalidateContentOnDrop, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public bool? InvalidateContentOnDrop { get; set; }

  /// <summary>
  ///   columns, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public Int64? IColumns { get; set; }

  /// <summary>
  ///   rows, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public Int64? IRows { get; set; }

  /// <summary>
  ///   itemWidth, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public Int64? ItemWidth { get; set; }

  /// <summary>
  ///   itemHeight, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public Int64? ItemHeight { get; set; }

  /// <summary>
  ///   getItemWidth, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? GetItemWidth { get; set; }

  /// <summary>
  ///   getItemHeight, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? GetItemHeight { get; set; }

  /// <summary>
  ///   showItemLabel, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public bool? ShowItemLabel { get; set; }

  /// <summary>
  ///   showInRibbon, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public GalleryShowInRibbonKind? ShowInRibbon { get; set; }

  /// <summary>
  ///   onAction, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? OnAction { get; set; }

  /// <summary>
  ///   enabled, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public bool? Enabled { get; set; }

  /// <summary>
  ///   getEnabled, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? GetEnabled { get; set; }

  /// <summary>
  ///   image, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? Image { get; set; }

  /// <summary>
  ///   imageMso, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? ImageMso { get; set; }

  /// <summary>
  ///   getImage, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? GetImage { get; set; }

  /// <summary>
  ///   showItemImage, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public bool? ShowItemImage { get; set; }

  /// <summary>
  ///   getItemCount, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? GetItemCount { get; set; }

  /// <summary>
  ///   getItemLabel, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? GetItemLabel { get; set; }

  /// <summary>
  ///   getItemScreentip, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? GetItemScreentip { get; set; }

  /// <summary>
  ///   getItemSupertip, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? GetItemSupertip { get; set; }

  /// <summary>
  ///   getItemImage, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? GetItemImage { get; set; }

  /// <summary>
  ///   getItemID, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? GetItemID { get; set; }

  /// <summary>
  ///   sizeString, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? SizeString { get; set; }

  /// <summary>
  ///   getSelectedItemID, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? GetSelectedItemID { get; set; }

  /// <summary>
  ///   getSelectedItemIndex, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? GetSelectedItemIndex { get; set; }

  /// <summary>
  ///   id, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? Id { get; set; }

  /// <summary>
  ///   idQ, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? QualifiedId { get; set; }

  /// <summary>
  ///   tag, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? Tag { get; set; }

  /// <summary>
  ///   idMso, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? IdMso { get; set; }

  /// <summary>
  ///   screentip, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? Screentip { get; set; }

  /// <summary>
  ///   getScreentip, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? GetScreentip { get; set; }

  /// <summary>
  ///   supertip, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? Supertip { get; set; }

  /// <summary>
  ///   getSupertip, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? GetSupertip { get; set; }

  /// <summary>
  ///   label, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? Label { get; set; }

  /// <summary>
  ///   getLabel, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? GetLabel { get; set; }

  /// <summary>
  ///   insertAfterMso, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? InsertAfterMso { get; set; }

  /// <summary>
  ///   insertBeforeMso, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? InsertBeforeMso { get; set; }

  /// <summary>
  ///   insertAfterQ, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? InsertAfterQulifiedId { get; set; }

  /// <summary>
  ///   insertBeforeQ, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? InsertBeforeQulifiedId { get; set; }

  /// <summary>
  ///   visible, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public bool? Visible { get; set; }

  /// <summary>
  ///   getVisible, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? GetVisible { get; set; }

  /// <summary>
  ///   keytip, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? Keytip { get; set; }

  /// <summary>
  ///   getKeytip, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? GetKeytip { get; set; }

  /// <summary>
  ///   showLabel, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public bool? ShowLabel { get; set; }

  /// <summary>
  ///   getShowLabel, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? GetShowLabel { get; set; }

  /// <summary>
  ///   showImage, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public bool? ShowImage { get; set; }

  /// <summary>
  ///   getShowImage, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? GetShowImage { get; set; }

  public Collection<Item>? Items { get; set; }

  public Collection<ButtonRegular>? ButtonRegulars { get; set; }
}
