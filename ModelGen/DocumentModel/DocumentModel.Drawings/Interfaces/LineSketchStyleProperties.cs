namespace DocumentModel.Drawings;

/// <summary>
/// Defines the LineSketchStyleProperties Class.
/// </summary>
public interface LineSketchStyleProperties // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// sd, this property is only available in Office 2021 and later.
  /// </summary>
  public UInt32? Sd { get ; set; }
  
  public CustomGeometry? CustomGeometry { get ; set; }
  
  public PresetGeometry? PresetGeometry { get ; set; }
  
  public LineSketchTypeProperties? LineSketchTypeProperties { get ; set; }
  
  public String? LineSketchSeed { get ; set; }
  
  public OfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
