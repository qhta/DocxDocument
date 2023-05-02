namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the ForegroundMark Class.
/// </summary>
public class ForegroundMark: ModelElement
{
  /// <summary>
  ///   x1, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? FirstXCoordinate { get; set; }

  /// <summary>
  ///   y1, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? FirstYCoordinate { get; set; }

  /// <summary>
  ///   x2, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? SecondXCoordinate { get; set; }

  /// <summary>
  ///   y2, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? SecondYCoordinate { get; set; }
}