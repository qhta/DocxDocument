using DocumentModel.Drawings;
namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the Properties3D Class.
/// </summary>
public interface Properties3D: ITypedModelElement, DrawingProperty
{
  /// <summary>
  ///   extrusionH
  /// </summary>
  public Int64? ExtrusionHeight { get; set; }
  /// <summary>
  ///   contourW
  /// </summary>
  public Int64? ContourWidth { get; set; }
  /// <summary>
  ///   prstMaterial
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