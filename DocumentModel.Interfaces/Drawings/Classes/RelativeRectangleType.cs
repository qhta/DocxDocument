namespace DocumentModel.Drawings;
/// <summary>
///   Defines the RelativeRectangleType interface.
/// </summary>
public interface RelativeRectangleType: IModelElement
{
  /// <summary>
  ///   Left Offset
  /// </summary>
  public Int32? Left { get; set; }
  /// <summary>
  ///   Top Offset
  /// </summary>
  public Int32? Top { get; set; }
  /// <summary>
  ///   Right Offset
  /// </summary>
  public Int32? Right { get; set; }
  /// <summary>
  ///   Bottom Offset
  /// </summary>
  public Int32? Bottom { get; set; }
}