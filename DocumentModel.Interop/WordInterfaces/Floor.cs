namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the floor of a 3-D chart.
/// </summary>
public partial interface Floor : InteropObject
{
  /// <summary>
  /// The name.
  /// </summary>
  public string Name { get; }

  /// <summary>
  /// The border.
  /// </summary>
  public ChartBorder Border { get; }

  /// <summary>
  /// The interior.
  /// </summary>
  public Interior Interior { get; }

  /// <summary>
  /// The fill.
  /// </summary>
  public ChartFillFormat Fill { get; }

  /// <summary>
  /// The picture type.
  /// </summary>
  public object PictureType { get; set; }

  /// <summary>
  /// The thickness.
  /// </summary>
  public int Thickness { get; set; }

  /// <summary>
  /// The format.
  /// </summary>
  public ChartFormat Format { get; }
}
