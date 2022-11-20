namespace DocumentModel.Office2019.Drawing.Model3D;

/// <summary>
/// Defines the Model3DTransform Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2019.Drawing.Model3D.IOfficeArtExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Office2019.Drawing.Model3D.IPreTransVector3D))]
[ChildElementInfo(typeof(DocumentModel.Office2019.Drawing.Model3D.IPostTransVector3D))]
[ChildElementInfo(typeof(DocumentModel.Office2019.Drawing.Model3D.IMeterPerModelUnitPositiveRatio))]
[ChildElementInfo(typeof(DocumentModel.Office2019.Drawing.Model3D.IRotate3D))]
[ChildElementInfo(typeof(DocumentModel.Office2019.Drawing.Model3D.IScale3D))]
public class Model3DTransform: IModel3DTransform
{
  /// <summary>
  /// MeterPerModelUnitPositiveRatio.
  /// </summary>
  public IMeterPerModelUnitPositiveRatio? MeterPerModelUnitPositiveRatio
  {
    get;
    set;
  }
  
  /// <summary>
  /// PreTransVector3D.
  /// </summary>
  public IPreTransVector3D? PreTransVector3D
  {
    get;
    set;
  }
  
  /// <summary>
  /// Scale3D.
  /// </summary>
  public IScale3D? Scale3D
  {
    get;
    set;
  }
  
  /// <summary>
  /// Rotate3D.
  /// </summary>
  public IRotate3D? Rotate3D
  {
    get;
    set;
  }
  
  /// <summary>
  /// PostTransVector3D.
  /// </summary>
  public IPostTransVector3D? PostTransVector3D
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
