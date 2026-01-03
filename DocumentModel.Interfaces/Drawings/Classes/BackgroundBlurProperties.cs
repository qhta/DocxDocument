namespace DocumentModel.Drawings;

/// <summary>
///   Defines the BackgroundBlurProperties interface.
/// </summary>
public interface BackgroundBlurProperties: IModelElement
{
  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  public OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
}