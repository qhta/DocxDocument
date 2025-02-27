namespace DocumentModel.Drawings;

/// <summary>
///   Defines the RelativeRectangleType Class.
/// </summary>
public class RelativeRectangleType: ModelElement
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