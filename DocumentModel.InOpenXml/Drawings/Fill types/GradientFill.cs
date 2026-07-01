namespace DocumentModel.Drawings;
/// <summary>
///   Defines the GradientFill class.
/// </summary>
[OpenXmlType(typeof(DXD.GradientFill))]
[DataContract]
[XmlRoot("GradientFill", Namespace = "DocumentModel.Drawings")]
public partial class GradientFill : Fill<DXD.GradientFill>
{
 /// <summary>
 ///   Tile Flip
 /// </summary>
 public TileFlip? Flip { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
 /// <summary>
 ///   Rotate With Shape
 /// </summary>
 public bool? RotateWithShape { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
 /// <summary>
 ///   Gradient Stop List.
 /// </summary>
 public GradientStopList? GradientStopList { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
 /// <summary>
 /// Relative rectangle coordinates.
 /// </summary>
 public RelativeRectangleType? TileRectangle { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}