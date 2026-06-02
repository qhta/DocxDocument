namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the up bars in a chart group.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.upbars?view=word-pia"/>
public partial class UpBars : InteropObject
{
  /// <summary>
  /// Returns a String value that represents the name of the object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.upbars.name?view=word-pia"/>
  public string? Name { get; set; }

  /// <summary>
  /// Returns a ChartBorder object that represents the border of the object. Read-only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.upbars.border?view=word-pia"/>
  public ChartBorder Border { get; set; }

  /// <summary>
  /// Returns an Interior object that represents the interior of the object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.upbars.interior?view=word-pia"/>
  public Interior Interior { get; set; }

  /// <summary>
  /// Returns a ChartFillFormat object for the parent chart element that contains fill formatting properties for the
  /// chart element. Read-only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.upbars.fill?view=word-pia"/>
  public ChartFillFormat Fill { get; set; }

  /// <summary>
  /// Returns the line, fill, and effect formatting for the object. Read-only ChartFormat.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.upbars.format?view=word-pia"/>
  public ChartFormat Format { get; set; }
}
