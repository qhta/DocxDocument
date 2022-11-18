namespace DocumentModel.Office2019.Drawing.Model3D;

/// <summary>
/// Defines the ObjectViewport Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2019.Drawing.Model3D.IOfficeArtExtensionList))]
public interface IObjectViewport // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// viewportSz, this property is only available in Office 2019 and later.
  /// </summary>
  public long? ViewportSz { get ; set; }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Office2019.Drawing.Model3D.IOfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
