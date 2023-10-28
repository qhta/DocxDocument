namespace DocumentModel.Drawings.SketchyShapes;


/// <summary>
///   Defines the LineSketchStyleProperties Class.
/// </summary>
public partial class LineSketchStyleProperties
{
  
  /// <summary>
  ///   sd, this property is only available in Office 2021 and later.
  /// </summary>
  public UInt32? Sd { get; set; }
  
  public DMD.CustomGeometry? CustomGeometry { get; set; }
  
  public DMD.PresetGeometry? PresetGeometry { get; set; }
  
  public DMDSS.LineSketchTypeProperties? LineSketchTypeProperties { get; set; }
  
  public DMDSS.LineSketchSeed? LineSketchSeed { get; set; }
  
  public DMDSS.OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
  
}
