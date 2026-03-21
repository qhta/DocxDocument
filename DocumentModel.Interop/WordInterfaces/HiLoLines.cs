namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the high-low lines in a chart group.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hilolines?view=word-pia"/>
public partial interface HiLoLines : InteropObject
{
  /// <summary>
  /// The name.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hilolines.name?view=word-pia"/>
  public string Name { get; }

  /// <summary>
  /// The border.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hilolines.border?view=word-pia"/>
  public ChartBorder Border { get; }

  /// <summary>
  /// The format.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hilolines.format?view=word-pia"/>
  public ChartFormat Format { get; }
}
