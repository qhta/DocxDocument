namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the ComboBox Class.
/// </summary>
public class ComboBox: ModelElement
{
  /// <summary>
  ///   showItemImage, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? ShowItemImage { get; set; }

  /// <summary>
  ///   getItemCount, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetItemCount { get; set; }

  /// <summary>
  ///   getItemLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetItemLabel { get; set; }

  /// <summary>
  ///   getItemScreentip, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetItemScreentip { get; set; }

  /// <summary>
  ///   getItemSupertip, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetItemSupertip { get; set; }

  /// <summary>
  ///   getItemImage, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetItemImage { get; set; }

  /// <summary>
  ///   getItemID, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetItemID { get; set; }

  /// <summary>
  ///   sizeString, this property is only available in Office 2010 and later.
  /// </summary>
  public string? SizeString { get; set; }

  /// <summary>
  ///   invalidateContentOnDrop, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? InvalidateContentOnDrop { get; set; }

  /// <summary>
  ///   enabled, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? Enabled { get; set; }

  /// <summary>
  ///   getEnabled, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetEnabled { get; set; }

  /// <summary>
  ///   image, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Image { get; set; }

  /// <summary>
  ///   imageMso, this property is only available in Office 2010 and later.
  /// </summary>
  public string? ImageMso { get; set; }

  /// <summary>
  ///   getImage, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetImage { get; set; }

  /// <summary>
  ///   maxLength, this property is only available in Office 2010 and later.
  /// </summary>
  public Int64? MaxLength { get; set; }

  /// <summary>
  ///   getText, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetText { get; set; }

  /// <summary>
  ///   onChange, this property is only available in Office 2010 and later.
  /// </summary>
  public string? OnChange { get; set; }

  /// <summary>
  ///   id, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Id { get; set; }

  /// <summary>
  ///   idQ, this property is only available in Office 2010 and later.
  /// </summary>
  public string? QualifiedId { get; set; }

  /// <summary>
  ///   tag, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Tag { get; set; }

  /// <summary>
  ///   idMso, this property is only available in Office 2010 and later.
  /// </summary>
  public string? IdMso { get; set; }

  /// <summary>
  ///   screentip, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Screentip { get; set; }

  /// <summary>
  ///   getScreentip, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetScreentip { get; set; }

  /// <summary>
  ///   supertip, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Supertip { get; set; }

  /// <summary>
  ///   getSupertip, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetSupertip { get; set; }

  /// <summary>
  ///   label, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Label { get; set; }

  /// <summary>
  ///   getLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetLabel { get; set; }

  /// <summary>
  ///   insertAfterMso, this property is only available in Office 2010 and later.
  /// </summary>
  public string? InsertAfterMso { get; set; }

  /// <summary>
  ///   insertBeforeMso, this property is only available in Office 2010 and later.
  /// </summary>
  public string? InsertBeforeMso { get; set; }

  /// <summary>
  ///   insertAfterQ, this property is only available in Office 2010 and later.
  /// </summary>
  public string? InsertAfterQulifiedId { get; set; }

  /// <summary>
  ///   insertBeforeQ, this property is only available in Office 2010 and later.
  /// </summary>
  public string? InsertBeforeQulifiedId { get; set; }

  /// <summary>
  ///   visible, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? Visible { get; set; }

  /// <summary>
  ///   getVisible, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetVisible { get; set; }

  /// <summary>
  ///   keytip, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Keytip { get; set; }

  /// <summary>
  ///   getKeytip, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetKeytip { get; set; }

  /// <summary>
  ///   showLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? ShowLabel { get; set; }

  /// <summary>
  ///   getShowLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetShowLabel { get; set; }

  /// <summary>
  ///   showImage, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? ShowImage { get; set; }

  /// <summary>
  ///   getShowImage, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetShowImage { get; set; }

  public Collection<Item>? Items { get; set; }
}