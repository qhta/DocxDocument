namespace DocumentModel.Office2019.Drawing.Model3D;

/// <summary>
/// Ambient light in a scene.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2019.Drawing.Model3D.IColorType))]
[ChildElementInfo(typeof(DocumentModel.Office2019.Drawing.Model3D.IOfficeArtExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Office2019.Drawing.Model3D.IIlluminancePositiveRatio))]
public interface IAmbientLight // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// enabled, this property is only available in Office 2019 and later.
  /// </summary>
  public bool? Enabled { get ; set; }
  
  /// <summary>
  /// ColorType.
  /// </summary>
  public DocumentModel.Office2019.Drawing.Model3D.IColorType? ColorType { get ; set; }
  
  /// <summary>
  /// IlluminancePositiveRatio.
  /// </summary>
  public IIlluminancePositiveRatio? IlluminancePositiveRatio { get ; set; }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Office2019.Drawing.Model3D.IOfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
