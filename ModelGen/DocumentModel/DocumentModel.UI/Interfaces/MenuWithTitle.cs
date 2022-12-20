namespace DocumentModel.UI;

/// <summary>
/// Defines the MenuWithTitle Class.
/// </summary>
public partial interface MenuWithTitle
{
  /// <summary>
  /// id
  /// </summary>
  public String? Id { get; set; }
  
  /// <summary>
  /// idQ
  /// </summary>
  public String? IdQ { get; set; }
  
  /// <summary>
  /// idMso
  /// </summary>
  public String? IdMso { get; set; }
  
  /// <summary>
  /// tag
  /// </summary>
  public String? Tag { get; set; }
  
  /// <summary>
  /// itemSize
  /// </summary>
  public DocumentModel.UI.ItemSizeKind? ItemSize { get; set; }
  
  /// <summary>
  /// title
  /// </summary>
  public String? Title { get; set; }
  
  /// <summary>
  /// getTitle
  /// </summary>
  public String? GetTitle { get; set; }
  
  /// <summary>
  /// image
  /// </summary>
  public String? Image { get; set; }
  
  /// <summary>
  /// imageMso
  /// </summary>
  public String? ImageMso { get; set; }
  
  /// <summary>
  /// getImage
  /// </summary>
  public String? GetImage { get; set; }
  
  /// <summary>
  /// screentip
  /// </summary>
  public String? Screentip { get; set; }
  
  /// <summary>
  /// getScreentip
  /// </summary>
  public String? GetScreentip { get; set; }
  
  /// <summary>
  /// supertip
  /// </summary>
  public String? Supertip { get; set; }
  
  /// <summary>
  /// getSupertip
  /// </summary>
  public String? GetSupertip { get; set; }
  
  /// <summary>
  /// enabled
  /// </summary>
  public Boolean? Enabled { get; set; }
  
  /// <summary>
  /// getEnabled
  /// </summary>
  public String? GetEnabled { get; set; }
  
  /// <summary>
  /// label
  /// </summary>
  public String? Label { get; set; }
  
  /// <summary>
  /// getLabel
  /// </summary>
  public String? GetLabel { get; set; }
  
  /// <summary>
  /// insertAfterMso
  /// </summary>
  public String? InsertAfterMso { get; set; }
  
  /// <summary>
  /// insertBeforeMso
  /// </summary>
  public String? InsertBeforeMso { get; set; }
  
  /// <summary>
  /// insertAfterQ
  /// </summary>
  public String? InsertAfterQ { get; set; }
  
  /// <summary>
  /// insertBeforeQ
  /// </summary>
  public String? InsertBeforeQ { get; set; }
  
  /// <summary>
  /// visible
  /// </summary>
  public Boolean? Visible { get; set; }
  
  /// <summary>
  /// getVisible
  /// </summary>
  public String? GetVisible { get; set; }
  
  /// <summary>
  /// keytip
  /// </summary>
  public String? Keytip { get; set; }
  
  /// <summary>
  /// getKeytip
  /// </summary>
  public String? GetKeytip { get; set; }
  
  /// <summary>
  /// showLabel
  /// </summary>
  public Boolean? ShowLabel { get; set; }
  
  /// <summary>
  /// getShowLabel
  /// </summary>
  public String? GetShowLabel { get; set; }
  
  /// <summary>
  /// showImage
  /// </summary>
  public Boolean? ShowImage { get; set; }
  
  /// <summary>
  /// getShowImage
  /// </summary>
  public String? GetShowImage { get; set; }
  
  public DocumentModel.UI.UnsizedControlClone? UnsizedControlClone { get; set; }
  
  public DocumentModel.UI.UnsizedButton? UnsizedButton { get; set; }
  
  public DocumentModel.UI.CheckBox? CheckBox { get; set; }
  
  public DocumentModel.UI.UnsizedGallery? UnsizedGallery { get; set; }
  
  public DocumentModel.UI.UnsizedToggleButton? UnsizedToggleButton { get; set; }
  
  public DocumentModel.UI.MenuSeparator? MenuSeparator { get; set; }
  
  public DocumentModel.UI.SplitButtonWithTitle? SplitButtonWithTitle { get; set; }
  
  public DocumentModel.UI.MenuWithTitle? ChildMenuWithTitle { get; set; }
  
  public DocumentModel.UI.UnsizedDynamicMenu? UnsizedDynamicMenu { get; set; }
  
}
