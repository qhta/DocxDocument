namespace DocumentModel.Drawings;

/// <summary>
///   Defines the BackgroundMark interface.
/// </summary>
public interface BackgroundMark: IModelElement
{
  /// <summary>
  ///   x1
  /// </summary>
  public Int32? FirstXCoordinate { get; set; }
  /// <summary>
  ///   y1
  /// </summary>
  public Int32? FirstYCoordinate { get; set; }
  /// <summary>
  ///   x2
  /// </summary>
  public Int32? SecondXCoordinate { get; set; }
  /// <summary>
  ///   y2
  /// </summary>
  public Int32? SecondYCoordinate { get; set; }
}