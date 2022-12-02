namespace DocumentModel.Drawing;

/// <summary>
/// Defines the LineSketchStyleProperties Class.
/// </summary>
public interface ILineSketchStyleProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// sd, this property is only available in Office 2021 and later.
  /// </summary>
  public UInt32? Sd { get ; set; }
  
  public ICustomGeometry? CustomGeometry { get ; set; }
  
  public IPresetGeometry? PresetGeometry { get ; set; }
  
  public ILineSketchTypeProperties? LineSketchTypeProperties { get ; set; }
  
  public String? LineSketchSeed { get ; set; }
  
  public IOfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
