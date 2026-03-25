namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents series lines in a chart group.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.serieslines?view=word-pia"/>
public partial interface SeriesLines : InteropObject
{
  /// <summary>
  /// Returns a String value that represents the name of the object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.serieslines.name?view=word-pia"/>
  public string Name { get; }

  /// <summary>
  /// Returns a ChartBorder object that represents the border of the object. Read-only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.serieslines.border?view=word-pia"/>
  public ChartBorder Border { get; }

  /// <summary>
  /// Returns the line, fill, and effect formatting for the object. Read-only ChartFormat.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.serieslines.format?view=word-pia"/>
  public ChartFormat Format { get; }
}
