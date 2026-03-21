namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the down bars in a chart group.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.downbars?view=word-pia"/>
public partial interface DownBars : InteropObject
{
  /// <summary>
  /// The name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.downbars.name?view=word-pia"/>
  public string Name { get; }

  /// <summary>
  /// The border.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.downbars.border?view=word-pia"/>
  public ChartBorder Border { get; }

  /// <summary>
  /// The interior.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.downbars.interior?view=word-pia"/>
  public Interior Interior { get; }

  /// <summary>
  /// The fill.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.downbars.fill?view=word-pia"/>
  public ChartFillFormat Fill { get; }

  /// <summary>
  /// The format.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.downbars.format?view=word-pia"/>
  public ChartFormat Format { get; }
}
