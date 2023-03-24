namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the LineSketchStyleProperties Class.
/// </summary>
public class LineSketchStyleProperties: ModelElement
{
  /// <summary>
  ///   sd, this property is only available in Office 2021 and later.
  /// </summary>
  public UInt32? Sd { get; set; }

  public CustomGeometry? CustomGeometry { get; set; }

  public PresetGeometry? PresetGeometry { get; set; }

  public LineSketchTypeProperties? LineSketchTypeProperties { get; set; }

  public String? LineSketchSeed { get; set; }

  public OfficeArtExtensionList6? OfficeArtExtensionList { get; set; }
}