namespace DocumentModel.UI;

/// <summary>
/// Defines CustomUI.
/// </summary>
public partial interface CustomUI
{
  /// <summary>
  /// Gets the CustomUIPart associated with this element, it could either be a QuickAccessToolbarCustomizationsPart or a RibbonExtensibilityPart.
  /// </summary>
  public DocumentModel.Packaging.CustomUIPart? CustomUIPart { get; set; }
  
  /// <summary>
  /// onLoad
  /// </summary>
  public String? OnLoad { get; set; }
  
  /// <summary>
  /// loadImage
  /// </summary>
  public String? LoadImage { get; set; }
  
  /// <summary>
  /// RepurposedCommands.
  /// </summary>
  public DocumentModel.UI.RepurposedCommands? RepurposedCommands { get; set; }
  
  /// <summary>
  /// Ribbon.
  /// </summary>
  public DocumentModel.UI.Ribbon? Ribbon { get; set; }
  
}
