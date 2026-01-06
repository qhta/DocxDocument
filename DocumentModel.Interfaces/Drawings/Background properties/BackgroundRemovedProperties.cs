namespace DocumentModel.Drawings;

/// <summary>
/// Represents properties for a background that has been removed, including an optional list of OfficeArt extensions for additional customization.
/// </summary>
public interface BackgroundRemovedProperties
{
  /// <summary>
  /// Gets or sets the OfficeArt extension list, which contains additional metadata or custom extensions for background removal properties.
  /// </summary>
  public OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
}