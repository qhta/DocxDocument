namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents leader lines on a chart. Leader lines connect data labels to data points.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.leaderlines?view=word-pia"/>
public partial interface LeaderLines : InteropObject
{
  /// <summary>
  /// The border.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.leaderlines.border?view=word-pia"/>
  public ChartBorder Border { get; }

  /// <summary>
  /// The format.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.leaderlines.format?view=word-pia"/>
  public ChartFormat Format { get; }
}
