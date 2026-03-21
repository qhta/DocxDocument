namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the error bars on a chart series.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.errorbars?view=word-pia"/>
public partial interface ErrorBars : InteropObject
{
  /// <summary>
  /// The name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.errorbars.name?view=word-pia"/>
  public string Name { get; }

  /// <summary>
  /// The border.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.errorbars.border?view=word-pia"/>
  public ChartBorder Border { get; }

  /// <summary>
  /// The end style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.errorbars.endstyle?view=word-pia"/>
  public XlEndStyleCap EndStyle { get; set; }

  /// <summary>
  /// The format.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.errorbars.format?view=word-pia"/>
  public ChartFormat Format { get; }
}
