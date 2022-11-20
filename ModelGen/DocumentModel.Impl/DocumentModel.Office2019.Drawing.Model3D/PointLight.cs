namespace DocumentModel.Office2019.Drawing.Model3D;

/// <summary>
/// Defines the PointLight Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2019.Drawing.Model3D.IColorType))]
[ChildElementInfo(typeof(DocumentModel.Office2019.Drawing.Model3D.IOfficeArtExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Office2019.Drawing.Model3D.IPosPoint3D))]
[ChildElementInfo(typeof(DocumentModel.Office2019.Drawing.Model3D.IIntensityPositiveRatio))]
public class PointLight: IPointLight
{
  /// <summary>
  /// enabled, this property is only available in Office 2019 and later.
  /// </summary>
  public bool? Enabled
  {
    get;
    set;
  }
  
  /// <summary>
  /// rad, this property is only available in Office 2019 and later.
  /// </summary>
  public long? Rad
  {
    get;
    set;
  }
  
  /// <summary>
  /// ColorType.
  /// </summary>
  public DocumentModel.Office2019.Drawing.Model3D.IColorType? ColorType
  {
    get;
    set;
  }
  
  /// <summary>
  /// IntensityPositiveRatio.
  /// </summary>
  public IIntensityPositiveRatio? IntensityPositiveRatio
  {
    get;
    set;
  }
  
  /// <summary>
  /// PosPoint3D.
  /// </summary>
  public IPosPoint3D? PosPoint3D
  {
    get;
    set;
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Office2019.Drawing.Model3D.IOfficeArtExtensionList? OfficeArtExtensionList
  {
    get;
    set;
  }
  
}
