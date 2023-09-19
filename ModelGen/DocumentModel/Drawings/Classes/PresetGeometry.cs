namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies when a preset geometric shape should be used instead of a custom geometric shape. The generating application should be able to render all preset geometries enumerated in the ST_ShapeType list.
/// </summary>
public partial class PresetGeometry
{
  
  /// <summary>
  ///   Specifies the preset geometry that is used for this shape. This preset can have any of the values in the enumerated list for ST_ShapeType. This attribute is required in order for a preset geometry to be rendered.
  /// </summary>
  [SchemaAttr("prst")]
  public DocumentModel.Drawings.ShapeTypeValues? Preset { get; set; }
  
  
  /// <summary>
  ///   List of Shape Adjust Values.
  /// </summary>
  public DocumentModel.Drawings.AdjustValueList? AdjustValueList { get; set; }
  
}
