namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Apply 3D shape properties.
/// </summary>
public class Shape3DType: ModelElement
{
  /// <summary>
  ///   Shape Depth
  /// </summary>
  public Int64? Z { get; set; }

  /// <summary>
  ///   Extrusion Height
  /// </summary>
  public Int64? ExtrusionHeight { get; set; }

  /// <summary>
  ///   Contour Width
  /// </summary>
  public Int64? ContourWidth { get; set; }

  /// <summary>
  ///   Preset Material Type
  /// </summary>
  public PresetMaterialKind? PresetMaterial { get; set; }

  /// <summary>
  ///   Top Bevel.
  /// </summary>
  public BevelType? BevelTop { get; set; }

  /// <summary>
  ///   Bottom Bevel.
  /// </summary>
  public BevelType? BevelBottom { get; set; }

  /// <summary>
  ///   Extrusion Color.
  /// </summary>
  public ExtrusionColor? ExtrusionColor { get; set; }

  /// <summary>
  ///   Contour Color.
  /// </summary>
  public ContourColor? ContourColor { get; set; }

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}