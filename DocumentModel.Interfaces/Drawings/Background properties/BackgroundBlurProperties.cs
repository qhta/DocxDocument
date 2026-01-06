namespace DocumentModel.Drawings;

/// <summary>
/// Represents background blur properties, including an optional list of OfficeArt extensions for additional customization.
/// </summary>
public interface BackgroundBlurProperties
{
  /// <summary>
  /// Gets or sets the OfficeArt extension list, which contains additional metadata or custom extensions for background blur.
  /// </summary>
  public OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
}