namespace DocumentModel.Drawings;

/// <summary>
/// Represents properties for a background that has been removed, including an optional list of OfficeArt extensions for additional customization.
/// </summary>
public class BackgroundRemovedProperties: ModelElement<DXO21DL.BackgroundRemovedProperties>, IOfficeArtExtendableElement
{
  /// <summary>
  /// List of OfficeArt extension elements.
  /// </summary>
  public OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
}