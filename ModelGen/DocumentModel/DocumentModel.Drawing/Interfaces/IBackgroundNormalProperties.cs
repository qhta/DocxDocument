namespace DocumentModel.Drawing;

/// <summary>
/// Defines the BackgroundNormalProperties Class.
/// </summary>
public interface IBackgroundNormalProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Drawing.IOfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
