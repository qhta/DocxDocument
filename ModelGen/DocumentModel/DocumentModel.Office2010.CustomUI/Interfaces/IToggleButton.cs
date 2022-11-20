namespace DocumentModel.Office2010.CustomUI;

/// <summary>
/// Defines the ToggleButton Class.
/// </summary>
public interface IToggleButton // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// size, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Office2010.CustomUI.SizeValues? Size { get ; set; }
  
  /// <summary>
  /// getSize, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetSize { get ; set; }
  
  /// <summary>
  /// getPressed, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetPressed { get ; set; }
  
  /// <summary>
  /// onAction, this property is only available in Office 2010 and later.
  /// </summary>
  public string? OnAction { get ; set; }
  
  /// <summary>
  /// enabled, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? Enabled { get ; set; }
  
  /// <summary>
  /// getEnabled, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetEnabled { get ; set; }
  
  /// <summary>
  /// description, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Description { get ; set; }
  
  /// <summary>
  /// getDescription, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetDescription { get ; set; }
  
  /// <summary>
  /// image, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Image { get ; set; }
  
  /// <summary>
  /// imageMso, this property is only available in Office 2010 and later.
  /// </summary>
  public string? ImageMso { get ; set; }
  
  /// <summary>
  /// getImage, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetImage { get ; set; }
  
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Id { get ; set; }
  
  /// <summary>
  /// idQ, this property is only available in Office 2010 and later.
  /// </summary>
  public string? QualifiedId { get ; set; }
  
  /// <summary>
  /// tag, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Tag { get ; set; }
  
  /// <summary>
  /// idMso, this property is only available in Office 2010 and later.
  /// </summary>
  public string? IdMso { get ; set; }
  
  /// <summary>
  /// screentip, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Screentip { get ; set; }
  
  /// <summary>
  /// getScreentip, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetScreentip { get ; set; }
  
  /// <summary>
  /// supertip, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Supertip { get ; set; }
  
  /// <summary>
  /// getSupertip, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetSupertip { get ; set; }
  
  /// <summary>
  /// label, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Label { get ; set; }
  
  /// <summary>
  /// getLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetLabel { get ; set; }
  
  /// <summary>
  /// insertAfterMso, this property is only available in Office 2010 and later.
  /// </summary>
  public string? InsertAfterMso { get ; set; }
  
  /// <summary>
  /// insertBeforeMso, this property is only available in Office 2010 and later.
  /// </summary>
  public string? InsertBeforeMso { get ; set; }
  
  /// <summary>
  /// insertAfterQ, this property is only available in Office 2010 and later.
  /// </summary>
  public string? InsertAfterQulifiedId { get ; set; }
  
  /// <summary>
  /// insertBeforeQ, this property is only available in Office 2010 and later.
  /// </summary>
  public string? InsertBeforeQulifiedId { get ; set; }
  
  /// <summary>
  /// visible, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? Visible { get ; set; }
  
  /// <summary>
  /// getVisible, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetVisible { get ; set; }
  
  /// <summary>
  /// keytip, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Keytip { get ; set; }
  
  /// <summary>
  /// getKeytip, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetKeytip { get ; set; }
  
  /// <summary>
  /// showLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? ShowLabel { get ; set; }
  
  /// <summary>
  /// getShowLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetShowLabel { get ; set; }
  
  /// <summary>
  /// showImage, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? ShowImage { get ; set; }
  
  /// <summary>
  /// getShowImage, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetShowImage { get ; set; }
  
}
