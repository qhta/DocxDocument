namespace DocumentModel.Office2021.Drawing.SketchyShapes;

/// <summary>
/// Defines the LineSketchStyleProperties Class.
/// </summary>
public interface ILineSketchStyleProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// sd, this property is only available in Office 2021 and later.
  /// </summary>
  public System.UInt32? Sd { get ; set; }
  
  public DocumentModel.Drawing.ICustomGeometry? CustomGeometry { get ; set; }
  
  public DocumentModel.Drawing.IPresetGeometry? PresetGeometry { get ; set; }
  
  public DocumentModel.Office2021.Drawing.SketchyShapes.ILineSketchTypeProperties? LineSketchTypeProperties { get ; set; }
  
  public System.String? LineSketchSeed { get ; set; }
  
  public DocumentModel.Office2021.Drawing.SketchyShapes.IOfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
