namespace DocumentModel.Drawings;

/// <summary>
///   Defines the LineSketchStyleProperties interface.
/// </summary>
public interface LineSketchStyleProperties: IModelElement
{
  /// <summary>
  ///   sd
  /// </summary>
  public UInt32? Sd { get; set; }
  public CustomGeometry? CustomGeometry { get; set; }
  public PresetGeometry? PresetGeometry { get; set; }
  public LineSketchTypeProperties? LineSketchTypeProperties { get; set; }
  public string? LineSketchSeed { get; set; }
  public OfficeArtExtensionList6? OfficeArtExtensionList { get; set; }
}