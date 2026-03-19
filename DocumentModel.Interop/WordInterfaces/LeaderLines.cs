namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents leader lines on a chart. Leader lines connect data labels to data points.
/// </summary>
public partial interface LeaderLines : InteropObject
{
  /// <summary>
  /// The border.
  /// </summary>
  public ChartBorder Border { get; }

  /// <summary>
  /// The format.
  /// </summary>
  public ChartFormat Format { get; }
}
