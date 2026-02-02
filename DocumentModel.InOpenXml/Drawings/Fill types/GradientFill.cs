namespace DocumentModel.Drawings;
/// <summary>
///   Defines the GradientFill class.
/// </summary>
[OpenXmlType(typeof(DXD.GradientFill))]
public partial class GradientFill : Fill<DXD.GradientFill>
{
 /// <summary>
 ///   Tile Flip
 /// </summary>
 public TileFlip? Flip { get; set; }
 /// <summary>
 ///   Rotate With Shape
 /// </summary>
 public bool? RotateWithShape { get; set; }
 /// <summary>
 ///   Gradient Stop List.
 /// </summary>
 public GradientStopList? GradientStopList { get; set; }
 /// <summary>
 /// Relative rectangle coordinates.
 /// </summary>
 public RelativeRectangleType? TileRectangle { get; set; }
}