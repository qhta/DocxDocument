namespace DocumentModel.Packaging;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines CustomUiPart. The CustomUiPart served as the base class of RibbonExtensibilityPart and
///   QuickAccessToolbarCustomizationsPart.
/// </summary>
public class CustomUIPart: ModelElement
{
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public UI.CustomUI? CustomUI { get; set; }
}