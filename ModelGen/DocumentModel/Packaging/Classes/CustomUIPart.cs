namespace DocumentModel.Packaging;


/// <summary>
///   Defines CustomUiPart. The CustomUiPart served as the base class of RibbonExtensibilityPart and QuickAccessToolbarCustomizationsPart.
/// </summary>
public partial class CustomUIPart
{
  
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.UI.CustomUI? CustomUI { get; set; }
  
}
