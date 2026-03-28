namespace DocumentModel.Interop;

/// <summary>
/// Represents the error bars on a chart series.
/// </summary>
public partial interface ErrorBars : InteropObject
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
  /// The end style.
  /// </summary>
  public Core.XlEndStyleCap EndStyle { get; set; }

  /// <summary>
  /// The format.
  /// </summary>
  public ChartFormat Format { get; }
}
