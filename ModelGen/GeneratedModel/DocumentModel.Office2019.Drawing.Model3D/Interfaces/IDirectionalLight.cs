namespace DocumentModel.Office2019.Drawing.Model3D;

/// <summary>
/// Defines the DirectionalLight Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2019.Drawing.Model3D.IColorType))]
[ChildElementInfo(typeof(DocumentModel.Office2019.Drawing.Model3D.IOfficeArtExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Office2019.Drawing.Model3D.IPosPoint3D))]
[ChildElementInfo(typeof(DocumentModel.Office2019.Drawing.Model3D.ILookAtPoint3D))]
[ChildElementInfo(typeof(DocumentModel.Office2019.Drawing.Model3D.IIlluminancePositiveRatio))]
public interface IDirectionalLight // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// enabled, this property is only available in Office 2019 and later.
  /// </summary>
  public bool? Enabled { get ; set; }
  
  /// <summary>
  /// angularRad, this property is only available in Office 2019 and later.
  /// </summary>
  public int? AngularRad { get ; set; }
  
  /// <summary>
  /// ColorType.
  /// </summary>
  public DocumentModel.Office2019.Drawing.Model3D.IColorType? ColorType { get ; set; }
  
  /// <summary>
  /// IlluminancePositiveRatio.
  /// </summary>
  public IIlluminancePositiveRatio? IlluminancePositiveRatio { get ; set; }
  
  /// <summary>
  /// PosPoint3D.
  /// </summary>
  public IPosPoint3D? PosPoint3D { get ; set; }
  
  /// <summary>
  /// LookAtPoint3D.
  /// </summary>
  public ILookAtPoint3D? LookAtPoint3D { get ; set; }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Office2019.Drawing.Model3D.IOfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
