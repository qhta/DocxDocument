namespace DocumentModel.Office.CustomUI;

/// <summary>
/// Defines the Gallery Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office.CustomUI.IUnsizedButton))]
[ChildElementInfo(typeof(DocumentModel.Office.CustomUI.IItem))]
public interface IGallery // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// size
  /// </summary>
  public DocumentModel.Office.CustomUI.SizeValues? Size { get ; set; }
  
  /// <summary>
  /// getSize
  /// </summary>
  public string? GetSize { get ; set; }
  
  /// <summary>
  /// description
  /// </summary>
  public string? Description { get ; set; }
  
  /// <summary>
  /// getDescription
  /// </summary>
  public string? GetDescription { get ; set; }
  
  /// <summary>
  /// invalidateContentOnDrop
  /// </summary>
  public bool? InvalidateContentOnDrop { get ; set; }
  
  /// <summary>
  /// columns
  /// </summary>
  public int? Columns { get ; set; }
  
  /// <summary>
  /// rows
  /// </summary>
  public int? Rows { get ; set; }
  
  /// <summary>
  /// itemWidth
  /// </summary>
  public int? ItemWidth { get ; set; }
  
  /// <summary>
  /// itemHeight
  /// </summary>
  public int? ItemHeight { get ; set; }
  
  /// <summary>
  /// getItemWidth
  /// </summary>
  public string? GetItemWidth { get ; set; }
  
  /// <summary>
  /// getItemHeight
  /// </summary>
  public string? GetItemHeight { get ; set; }
  
  /// <summary>
  /// showItemLabel
  /// </summary>
  public bool? ShowItemLabel { get ; set; }
  
  /// <summary>
  /// onAction
  /// </summary>
  public string? OnAction { get ; set; }
  
  /// <summary>
  /// enabled
  /// </summary>
  public bool? Enabled { get ; set; }
  
  /// <summary>
  /// getEnabled
  /// </summary>
  public string? GetEnabled { get ; set; }
  
  /// <summary>
  /// image
  /// </summary>
  public string? Image { get ; set; }
  
  /// <summary>
  /// imageMso
  /// </summary>
  public string? ImageMso { get ; set; }
  
  /// <summary>
  /// getImage
  /// </summary>
  public string? GetImage { get ; set; }
  
  /// <summary>
  /// showItemImage
  /// </summary>
  public bool? ShowItemImage { get ; set; }
  
  /// <summary>
  /// getItemCount
  /// </summary>
  public string? GetItemCount { get ; set; }
  
  /// <summary>
  /// getItemLabel
  /// </summary>
  public string? GetItemLabel { get ; set; }
  
  /// <summary>
  /// getItemScreentip
  /// </summary>
  public string? GetItemScreentip { get ; set; }
  
  /// <summary>
  /// getItemSupertip
  /// </summary>
  public string? GetItemSupertip { get ; set; }
  
  /// <summary>
  /// getItemImage
  /// </summary>
  public string? GetItemImage { get ; set; }
  
  /// <summary>
  /// getItemID
  /// </summary>
  public string? GetItemID { get ; set; }
  
  /// <summary>
  /// sizeString
  /// </summary>
  public string? SizeString { get ; set; }
  
  /// <summary>
  /// getSelectedItemID
  /// </summary>
  public string? GetSelectedItemID { get ; set; }
  
  /// <summary>
  /// getSelectedItemIndex
  /// </summary>
  public string? GetSelectedItemIndex { get ; set; }
  
  /// <summary>
  /// id
  /// </summary>
  public string? Id { get ; set; }
  
  /// <summary>
  /// idQ
  /// </summary>
  public string? IdQ { get ; set; }
  
  /// <summary>
  /// idMso
  /// </summary>
  public string? IdMso { get ; set; }
  
  /// <summary>
  /// tag
  /// </summary>
  public string? Tag { get ; set; }
  
  /// <summary>
  /// screentip
  /// </summary>
  public string? Screentip { get ; set; }
  
  /// <summary>
  /// getScreentip
  /// </summary>
  public string? GetScreentip { get ; set; }
  
  /// <summary>
  /// supertip
  /// </summary>
  public string? Supertip { get ; set; }
  
  /// <summary>
  /// getSupertip
  /// </summary>
  public string? GetSupertip { get ; set; }
  
  /// <summary>
  /// label
  /// </summary>
  public string? Label { get ; set; }
  
  /// <summary>
  /// getLabel
  /// </summary>
  public string? GetLabel { get ; set; }
  
  /// <summary>
  /// insertAfterMso
  /// </summary>
  public string? InsertAfterMso { get ; set; }
  
  /// <summary>
  /// insertBeforeMso
  /// </summary>
  public string? InsertBeforeMso { get ; set; }
  
  /// <summary>
  /// insertAfterQ
  /// </summary>
  public string? InsertAfterQ { get ; set; }
  
  /// <summary>
  /// insertBeforeQ
  /// </summary>
  public string? InsertBeforeQ { get ; set; }
  
  /// <summary>
  /// visible
  /// </summary>
  public bool? Visible { get ; set; }
  
  /// <summary>
  /// getVisible
  /// </summary>
  public string? GetVisible { get ; set; }
  
  /// <summary>
  /// keytip
  /// </summary>
  public string? Keytip { get ; set; }
  
  /// <summary>
  /// getKeytip
  /// </summary>
  public string? GetKeytip { get ; set; }
  
  /// <summary>
  /// showLabel
  /// </summary>
  public bool? ShowLabel { get ; set; }
  
  /// <summary>
  /// getShowLabel
  /// </summary>
  public string? GetShowLabel { get ; set; }
  
  /// <summary>
  /// showImage
  /// </summary>
  public bool? ShowImage { get ; set; }
  
  /// <summary>
  /// getShowImage
  /// </summary>
  public string? GetShowImage { get ; set; }
  
}
