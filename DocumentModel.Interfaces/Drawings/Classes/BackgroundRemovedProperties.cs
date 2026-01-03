namespace DocumentModel.Drawings;

/// <summary>
///   Defines the BackgroundRemovedProperties interface.
/// </summary>
public interface BackgroundRemovedProperties: IModelElement
{
  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  public OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
}