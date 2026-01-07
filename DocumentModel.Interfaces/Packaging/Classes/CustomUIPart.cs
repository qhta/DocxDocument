namespace DocumentModel.Packaging;

/// <summary>
///   Defines CustomUiPart. The CustomUiPart served as the base interface of RibbonExtensibilityPart and
///   QuickAccessToolbarCustomizationsPart.
/// </summary>
public interface CustomUIPart: OpenXmlPart
{
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public UI.CustomUI? CustomUI { get; set; }
}