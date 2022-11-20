namespace DocumentModel.Office2019.Drawing.Model3D;

/// <summary>
/// Defines the PerspectiveProjection Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2019.Drawing.Model3D.IOfficeArtExtensionList))]
public interface IPerspectiveProjection // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// fov, this property is only available in Office 2019 and later.
  /// </summary>
  public int? Fov { get ; set; }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Office2019.Drawing.Model3D.IOfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
