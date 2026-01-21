using DocumentModel.Drawings;

namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Represents the set of 3D properties for a drawing element in a Wordprocessing document.
/// This interface provides configuration for extrusion height, contour width, preset material, bevel effects, and color settings, enabling advanced 3D appearance and rendering for graphical objects.
/// </summary>
public partial class Properties3D : DrawingProperty
{
  /// <summary>
  /// The height of the extrusion effect, specified in EMUs (English Metric Units), determining the depth of the 3D extrusion.
  /// </summary>
  public Int64? ExtrusionHeight { get; set; }
  /// <summary>
  /// The width of the contour applied to the 3D object, specified in EMUs, controlling the thickness of the outline.
  /// </summary>
  public Int64? ContourWidth { get; set; }
  /// <summary>
  /// The preset material type used for rendering the 3D object, defining surface appearance such as matte, plastic, or metal.
  /// </summary>
  public PresetMaterialKind? PresetMaterialType { get; set; }
  /// <summary>
  /// The bevel effect applied to the top face of the 3D object, specifying shape and size.
  /// </summary>
  public BevelType? BevelTop { get; set; }
  /// <summary>
  /// The bevel effect applied to the bottom face of the 3D object, specifying shape and size.
  /// </summary>
  public BevelType? BevelBottom { get; set; }
  /// <summary>
  /// The color used for the extrusion effect, allowing customization of the 3D extrusion's appearance.
  /// </summary>
  public ExtrusionColor? ExtrusionColor { get; set; }
  /// <summary>
  /// The color used for the contour of the 3D object, allowing customization of the outline's appearance.
  /// </summary>
  public ContourColor? ContourColor { get; set; }
}