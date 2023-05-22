using DocumentModel.Drawings;

namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the Properties3D Class.
/// </summary>
public class Properties3D: TypedModelElement, IDrawingProperty
{
  /// <summary>
  ///   extrusionH, this property is only available in Office 2010 and later.
  /// </summary>
  public Int64? ExtrusionHeight { get; set; }

  /// <summary>
  ///   contourW, this property is only available in Office 2010 and later.
  /// </summary>
  public Int64? ContourWidth { get; set; }

  /// <summary>
  ///   prstMaterial, this property is only available in Office 2010 and later.
  /// </summary>
  public PresetMaterialKind? PresetMaterialType { get; set; }

  /// <summary>
  ///   BevelTop.
  /// </summary>
  public BevelType? BevelTop { get; set; }

  /// <summary>
  ///   BevelBottom.
  /// </summary>
  public BevelType? BevelBottom { get; set; }

  /// <summary>
  ///   ExtrusionColor.
  /// </summary>
  public ExtrusionColor? ExtrusionColor { get; set; }

  /// <summary>
  ///   ContourColor.
  /// </summary>
  public ContourColor? ContourColor { get; set; }
}