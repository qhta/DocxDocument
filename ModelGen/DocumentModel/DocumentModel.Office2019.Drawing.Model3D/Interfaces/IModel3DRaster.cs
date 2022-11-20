namespace DocumentModel.Office2019.Drawing.Model3D;

/// <summary>
/// Defines the Model3DRaster Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2019.Drawing.Model3D.IBlip))]
public interface IModel3DRaster // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// rName, this property is only available in Office 2019 and later.
  /// </summary>
  public string? RName { get ; set; }
  
  /// <summary>
  /// rVer, this property is only available in Office 2019 and later.
  /// </summary>
  public string? RVer { get ; set; }
  
  /// <summary>
  /// Blip.
  /// </summary>
  public DocumentModel.Office2019.Drawing.Model3D.IBlip? Blip { get ; set; }
  
}
