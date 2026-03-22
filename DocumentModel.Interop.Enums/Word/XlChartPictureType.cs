namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how pictures are displayed on a column, bar picture chart, or legend key.
/// </summary>
public enum XlChartPictureType
{
  /// <summary>
  /// Picture is stretched the full length of the stacked bar.
  /// </summary>
  xlStretch = unchecked((int)1),
  /// <summary>
  /// Picture is sized to repeat a maximum
  /// </summary>
  xlStack = unchecked((int)2),
  /// <summary>
  /// Specifies how pictures are displayed on a column, bar picture chart, or legend key.
  /// </summary>
  xlStackScale = unchecked((int)3)
}
