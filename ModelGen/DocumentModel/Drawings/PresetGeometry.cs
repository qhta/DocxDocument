namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies when a preset geometric shape should be used instead of a custom geometric shape. The generating application should be able to render all preset geometries enumerated in the ST_ShapeType list.
/// </summary>
public partial class PresetGeometry
{
  
  /// <summary>
  ///   List of Shape Adjust Values.
  /// </summary>
  public DMD.AdjustValueList? AdjustValueList { get; set; }
  
}
