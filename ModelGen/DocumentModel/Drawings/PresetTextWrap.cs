namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies when a preset geometric shape should be used to transform a piece of text. This operation is known formally as a text warp. The generating application should be able to render all preset geometries enumerated in the ST_TextShapeType list.
/// </summary>
public partial class PresetTextWrap
{
  
  /// <summary>
  ///   Adjust Value List.
  /// </summary>
  public DMD.AdjustValueList? AdjustValueList { get; set; }
  
}
