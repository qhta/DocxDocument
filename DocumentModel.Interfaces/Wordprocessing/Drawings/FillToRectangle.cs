namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the FillToRectangle Class.
/// </summary>
public interface FillToRectangle: IModelElement
{
  /// <summary>
  ///   l
  /// </summary>
  public Int32? Left { get; set; }
  /// <summary>
  ///   t
  /// </summary>
  public Int32? Top { get; set; }
  /// <summary>
  ///   r
  /// </summary>
  public Int32? Right { get; set; }
  /// <summary>
  ///   b
  /// </summary>
  public Int32? Bottom { get; set; }
}