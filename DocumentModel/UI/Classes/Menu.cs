namespace DocumentModel.UI;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the Menu Class.
/// </summary>
public class Menu: ModelElement
{
  /// <summary>
  ///   size
  /// </summary>
  public SizeKind? Size { get; set; }

  /// <summary>
  ///   getSize
  /// </summary>
  public string? GetSize { get; set; }

  /// <summary>
  ///   itemSize
  /// </summary>
  public ItemSizeKind? ItemSize { get; set; }

  /// <summary>
  ///   description
  /// </summary>
  public string? Description { get; set; }

  /// <summary>
  ///   getDescription
  /// </summary>
  public string? GetDescription { get; set; }

  /// <summary>
  ///   id
  /// </summary>
  public string? Id { get; set; }

  /// <summary>
  ///   idQ
  /// </summary>
  public string? IdQ { get; set; }

  /// <summary>
  ///   idMso
  /// </summary>
  public string? IdMso { get; set; }

  /// <summary>
  ///   tag
  /// </summary>
  public string? Tag { get; set; }

  /// <summary>
  ///   image
  /// </summary>
  public string? Image { get; set; }

  /// <summary>
  ///   imageMso
  /// </summary>
  public string? ImageMso { get; set; }

  /// <summary>
  ///   getImage
  /// </summary>
  public string? GetImage { get; set; }

  /// <summary>
  ///   screentip
  /// </summary>
  public string? Screentip { get; set; }

  /// <summary>
  ///   getScreentip
  /// </summary>
  public string? GetScreentip { get; set; }

  /// <summary>
  ///   supertip
  /// </summary>
  public string? Supertip { get; set; }

  /// <summary>
  ///   getSupertip
  /// </summary>
  public string? GetSupertip { get; set; }

  /// <summary>
  ///   enabled
  /// </summary>
  public bool? Enabled { get; set; }

  /// <summary>
  ///   getEnabled
  /// </summary>
  public string? GetEnabled { get; set; }

  /// <summary>
  ///   label
  /// </summary>
  public string? Label { get; set; }

  /// <summary>
  ///   getLabel
  /// </summary>
  public string? GetLabel { get; set; }

  /// <summary>
  ///   insertAfterMso
  /// </summary>
  public string? InsertAfterMso { get; set; }

  /// <summary>
  ///   insertBeforeMso
  /// </summary>
  public string? InsertBeforeMso { get; set; }

  /// <summary>
  ///   insertAfterQ
  /// </summary>
  public string? InsertAfterQ { get; set; }

  /// <summary>
  ///   insertBeforeQ
  /// </summary>
  public string? InsertBeforeQ { get; set; }

  /// <summary>
  ///   visible
  /// </summary>
  public bool? Visible { get; set; }

  /// <summary>
  ///   getVisible
  /// </summary>
  public string? GetVisible { get; set; }

  /// <summary>
  ///   keytip
  /// </summary>
  public string? Keytip { get; set; }

  /// <summary>
  ///   getKeytip
  /// </summary>
  public string? GetKeytip { get; set; }

  /// <summary>
  ///   showLabel
  /// </summary>
  public bool? ShowLabel { get; set; }

  /// <summary>
  ///   getShowLabel
  /// </summary>
  public string? GetShowLabel { get; set; }

  /// <summary>
  ///   showImage
  /// </summary>
  public bool? ShowImage { get; set; }

  /// <summary>
  ///   getShowImage
  /// </summary>
  public string? GetShowImage { get; set; }

  public UnsizedControlClone? UnsizedControlClone { get; set; }

  public UnsizedButton? UnsizedButton { get; set; }

  public CheckBox? CheckBox { get; set; }

  public UnsizedGallery? UnsizedGallery { get; set; }

  public UnsizedToggleButton? UnsizedToggleButton { get; set; }

  public MenuSeparator? MenuSeparator { get; set; }

  public UnsizedSplitButton? UnsizedSplitButton { get; set; }

  public UnsizedMenu? UnsizedMenu { get; set; }

  public UnsizedDynamicMenu? UnsizedDynamicMenu { get; set; }
}