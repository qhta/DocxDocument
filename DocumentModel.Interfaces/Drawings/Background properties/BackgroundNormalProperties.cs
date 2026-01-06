namespace DocumentModel.Drawings;

/// <summary>
/// Represents normal background properties, including an optional list of OfficeArt extensions for additional customization.
/// </summary>
public interface BackgroundNormalProperties
{
  /// <summary>
  /// Gets or sets the OfficeArt extension list, which contains additional metadata or custom extensions for normal background properties.
  /// </summary>
  public OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
}