namespace DocumentModel.Office2019.Drawing.Model3D;

/// <summary>
/// Defines the WindowViewport Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2019.Drawing.Model3D.IOfficeArtExtensionList))]
public interface IWindowViewport // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Office2019.Drawing.Model3D.IOfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
