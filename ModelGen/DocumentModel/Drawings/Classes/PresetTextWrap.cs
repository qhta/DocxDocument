namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies when a preset geometric shape should be used to transform a piece of text. This operation is known formally as a text warp. The generating application should be able to render all preset geometries enumerated in the ST_TextShapeType list.
/// </summary>
public partial class PresetTextWrap
{
  
  /// <summary>
  ///   Specifies the preset geometry that is used for a shape warp on a piece of text. This preset can have any of the values in the enumerated list for ST_TextShapeType. This attribute is required in order for a text warp to be rendered.
  /// </summary>
  [SchemaAttr("prst")]
  public DocumentModel.Drawings.TextShapeValues? Preset { get; set; }
  
  
  /// <summary>
  ///   Adjust Value List.
  /// </summary>
  public DocumentModel.Drawings.AdjustValueList? AdjustValueList { get; set; }
  
}
