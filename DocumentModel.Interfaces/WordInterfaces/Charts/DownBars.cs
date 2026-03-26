namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the down bars in a chart group.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.downbars?view=word-pia"/>
public partial interface DownBars : InteropObject
{
  /// <summary>
  /// Gets the name of the `DownBars` object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.downbars.name?view=word-pia"/>
  public string Name { get; }

  /// <summary>
  /// Gets the border formatting for the down bars.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.downbars.border?view=word-pia"/>
  public ChartBorder Border { get; }

  /// <summary>
  /// Gets the interior formatting of the down bars.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.downbars.interior?view=word-pia"/>
  public Interior Interior { get; }

  /// <summary>
  /// Gets the fill formatting of the down bars.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.downbars.fill?view=word-pia"/>
  public ChartFillFormat Fill { get; }

  /// <summary>
  /// Gets the chart formatting for the down bars.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.downbars.format?view=word-pia"/>
  public ChartFormat Format { get; }
}
