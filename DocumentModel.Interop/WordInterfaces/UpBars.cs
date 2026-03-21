namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the up bars in a chart group.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.upbars?view=word-pia"/>
public partial interface UpBars : InteropObject
{
  /// <summary>
  /// Returns the name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.upbars.name?view=word-pia"/>
  public string Name { get; }

  /// <summary>
  /// Returns the border.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.upbars.border?view=word-pia"/>
  public ChartBorder Border { get; }

  /// <summary>
  /// Returns the interior.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.upbars.interior?view=word-pia"/>
  public Interior Interior { get; }

  /// <summary>
  /// Returns the fill.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.upbars.fill?view=word-pia"/>
  public ChartFillFormat Fill { get; }

  /// <summary>
  /// Returns the format.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.upbars.format?view=word-pia"/>
  public ChartFormat Format { get; }
}
