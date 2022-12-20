namespace DocumentModel;

/// <summary>
/// Defines the CustomUI Class.
/// </summary>
public partial interface CustomUI
{
  /// <summary>
  /// onLoad, this property is only available in Office 2010 and later.
  /// </summary>
  public String? OnLoad { get; set; }
  
  /// <summary>
  /// loadImage, this property is only available in Office 2010 and later.
  /// </summary>
  public String? LoadImage { get; set; }
  
  /// <summary>
  /// Commands.
  /// </summary>
  public DocumentModel.Commands? Commands { get; set; }
  
  /// <summary>
  /// Ribbon.
  /// </summary>
  public DocumentModel.Ribbon? Ribbon { get; set; }
  
  /// <summary>
  /// Backstage.
  /// </summary>
  public DocumentModel.Backstage? Backstage { get; set; }
  
  /// <summary>
  /// ContextMenus.
  /// </summary>
  public DocumentModel.ContextMenus? ContextMenus { get; set; }
  
  /// <summary>
  /// Gets the RibbonAndBackstageCustomizationsPart associated with this element.
  /// </summary>
  public DocumentModel.Packaging.RibbonAndBackstageCustomizationsPart? RibbonAndBackstageCustomizationsPart { get; set; }
  
}
