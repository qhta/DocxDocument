namespace DocumentModel.Drawing;

/// <summary>
/// Defines the BackgroundBlurProperties Class.
/// </summary>
public interface IBackgroundBlurProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Drawing.IOfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
