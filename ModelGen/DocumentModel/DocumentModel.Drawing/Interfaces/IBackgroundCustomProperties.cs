namespace DocumentModel.Drawing;

/// <summary>
/// Defines the BackgroundCustomProperties Class.
/// </summary>
public interface IBackgroundCustomProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Drawing.IOfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
