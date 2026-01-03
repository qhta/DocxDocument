namespace DocumentModel.Drawings;

/// <summary>
///   Defines the BackgroundNormalProperties interface.
/// </summary>
public interface BackgroundNormalProperties: IModelElement
{
  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  public OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
}