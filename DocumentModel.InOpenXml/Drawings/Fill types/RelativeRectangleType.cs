namespace DocumentModel.Drawings;
/// <summary>
///   Represents a rectangle defined by relative offsets for each side, used for specifying areas within a parent element.
/// </summary>
public partial class RelativeRectangleType : ModelElement
{
  /// <summary>
  ///   Left offset of the rectangle.
  /// </summary>
  public Int32? Left { get; set; }
  /// <summary>
  ///   Top offset of the rectangle.
  /// </summary>
  public Int32? Top { get; set; }
  /// <summary>
  ///   Right offset of the rectangle.
  /// </summary>
  public Int32? Right { get; set; }
  /// <summary>
  ///   Bottom offset of the rectangle.
  /// </summary>
  public Int32? Bottom { get; set; }
}