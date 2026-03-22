namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies what the bubble size represents on a bubble chart.
/// </summary>
public enum XlSizeRepresents
{
  /// <summary>
  /// Area of the bubble.
  /// </summary>
  xlSizeIsArea = unchecked((int)1),
  /// <summary>
  /// Width of the bubble.
  /// </summary>
  xlSizeIsWidth = unchecked((int)2)
}
