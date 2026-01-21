namespace DocumentModel.Drawings;
/// <summary>
///   Represents a relative offset effect, specifying X and Y offset values for positioning.
/// </summary>
public partial class RelativeOffset : ModelElement
{
  /// <summary>
  ///   X offset value.
  /// </summary>
  public Int32? OffsetX { get; set; }
  /// <summary>
  ///   Y offset value.
  /// </summary>
  public Int32? OffsetY { get; set; }
}