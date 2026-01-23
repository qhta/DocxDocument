namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Defines properties for a 3-D shape, including depth, extrusion, contour, material, bevels, and color settings.
/// </summary>
public class Shape3D : ModelElement<DXDD.Shape3D>, IExtendableElement
{
  /// <summary>
  ///   Shape depth along the Z-axis.
  /// </summary>
  public Int64? Z { get; set; }

  /// <summary>
  ///   Height of the extrusion applied to the shape.
  /// </summary>
  public Int64? ExtrusionHeight { get; set; }

  /// <summary>
  ///   Width of the contour around the shape.
  /// </summary>
  public Int64? ContourWidth { get; set; }

  /// <summary>
  ///   Preset material type applied to the shape's surface.
  /// </summary>
  public PresetMaterialKind? PresetMaterial { get; set; }

  /// <summary>
  ///   Top bevel effect applied to the shape.
  /// </summary>
  public BevelType? BevelTop { get; set; }

  /// <summary>
  ///   Bottom bevel effect applied to the shape.
  /// </summary>
  public BevelType? BevelBottom { get; set; }

  /// <summary>
  ///   Color used for the extrusion.
  /// </summary>
  public ExtrusionColor? ExtrusionColor { get; set; }

  /// <summary>
  ///   Color used for the contour.
  /// </summary>
  public ContourColor? ContourColor { get; set; }

  /// <summary>
  /// Gets or sets the list of extensions associated with this object.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}