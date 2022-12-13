namespace DocumentModel.Drawings;

/// <summary>
/// Defines the LineSketchStyleProperties Class.
/// </summary>
public interface LineSketchStyleProperties
{
  /// <summary>
  /// sd, this property is only available in Office 2021 and later.
  /// </summary>
  public UInt32? Sd { get ; set; }
  
  public DocumentModel.Drawings.CustomGeometry? CustomGeometry { get ; set; }
  
  public DocumentModel.Drawings.PresetGeometry? PresetGeometry { get ; set; }
  
  public DocumentModel.Drawings.LineSketchTypeProperties? LineSketchTypeProperties { get ; set; }
  
  public String? LineSketchSeed { get ; set; }
  
  public DocumentModel.Drawings.OfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
