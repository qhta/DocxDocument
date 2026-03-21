namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the drop lines in a chart group.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.droplines?view=word-pia"/>
public partial interface DropLines : InteropObject
{
  /// <summary>
  /// Gets the name of the `DropLines` object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.droplines.name?view=word-pia"/>
  public string Name { get; }

  /// <summary>
  /// Gets the border formatting for the drop lines.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.droplines.border?view=word-pia"/>
  public ChartBorder Border { get; }

  /// <summary>
  /// Gets the chart formatting for the drop lines.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.droplines.format?view=word-pia"/>
  public ChartFormat Format { get; }
}
