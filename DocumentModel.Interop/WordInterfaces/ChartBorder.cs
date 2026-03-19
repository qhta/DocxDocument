namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the border of an object.
/// </summary>
public interface ChartBorder : InteropObject
{
  /// <summary>
  /// The color.
  /// </summary>
  public object Color { get; set; }
  /// <summary>
  /// The color index.
  /// </summary>
  public object ColorIndex { get; set; }
  /// <summary>
  /// The line style.
  /// </summary>
  public object LineStyle { get; set; }
  /// <summary>
  /// The weight.
  /// </summary>
  public object Weight { get; set; }

}
