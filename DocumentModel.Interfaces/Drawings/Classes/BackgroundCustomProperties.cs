namespace DocumentModel.Drawings;

/// <summary>
///   Defines the BackgroundCustomProperties interface.
/// </summary>
public interface BackgroundCustomProperties: IModelElement
{
  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  public OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
}