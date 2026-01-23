namespace DocumentModel.Drawings;

/// <summary>
/// Represents normal background properties, including an optional list of OfficeArt extensions for additional customization.
/// </summary>
public class BackgroundNormalProperties: ModelElement<DXO21DL.BackgroundNormalProperties>, IOfficeArtExtendableElement
{
  /// <summary>
  /// List of OfficeArt extension elements.
  /// </summary>
  public OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
}