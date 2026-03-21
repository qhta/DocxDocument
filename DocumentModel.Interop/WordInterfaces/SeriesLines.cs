namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents series lines in a chart group.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.serieslines?view=word-pia"/>
public partial interface SeriesLines : InteropObject
{
  /// <summary>
  /// The name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.serieslines.name?view=word-pia"/>
  public string Name { get; }

  /// <summary>
  /// The border.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.serieslines.border?view=word-pia"/>
  public ChartBorder Border { get; }

  /// <summary>
  /// The format.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.serieslines.format?view=word-pia"/>
  public ChartFormat Format { get; }
}
