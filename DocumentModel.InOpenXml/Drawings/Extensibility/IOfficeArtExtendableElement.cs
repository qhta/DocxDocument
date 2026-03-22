namespace DocumentModel.Drawings;
/// <summary>
/// Element that can specify the extension list within which all future extensions of element type are defined.
/// The extension list along with corresponding future extensions is used to extend the storage capabilities of the DrawingML framework.
/// This allows for various new types of data to be stored natively within the framework.
/// </summary>
public interface IOfficeArtExtendableElement
{
  /// <summary>
  /// Extension list for future extensions of the element type.
  /// </summary>
  public OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
}