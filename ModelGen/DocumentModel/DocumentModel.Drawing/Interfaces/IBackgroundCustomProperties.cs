namespace DocumentModel.Drawing;

/// <summary>
/// Defines the BackgroundCustomProperties Class.
/// </summary>
public interface IBackgroundCustomProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public IOfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
