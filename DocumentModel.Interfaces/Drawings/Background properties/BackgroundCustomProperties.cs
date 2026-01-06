namespace DocumentModel.Drawings;

/// <summary>
/// Represents custom background properties, including an optional list of OfficeArt extensions for additional customization.
/// </summary>
public interface BackgroundCustomProperties
{
  /// <summary>
  /// Gets or sets the OfficeArt extension list, which contains additional metadata or custom extensions for background customization.
  /// </summary>
  public OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
}