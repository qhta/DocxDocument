namespace DocumentModel.Office2019.Drawing.Model3D;

/// <summary>
/// Defines the Scale3D Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2019.Drawing.Model3D.ISxRatio))]
[ChildElementInfo(typeof(DocumentModel.Office2019.Drawing.Model3D.ISyRatio))]
[ChildElementInfo(typeof(DocumentModel.Office2019.Drawing.Model3D.ISzRatio))]
public class Scale3D: IScale3D
{
  /// <summary>
  /// SxRatio.
  /// </summary>
  public ISxRatio? SxRatio
  {
    get;
    set;
  }
  
  /// <summary>
  /// SyRatio.
  /// </summary>
  public ISyRatio? SyRatio
  {
    get;
    set;
  }
  
  /// <summary>
  /// SzRatio.
  /// </summary>
  public ISzRatio? SzRatio
  {
    get;
    set;
  }
  
}
