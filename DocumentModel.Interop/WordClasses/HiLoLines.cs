namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents high-low lines in a chart group.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hilolines?view=word-pia"/>
public partial class HiLoLines : InteropObject
{
  /// <summary>
  /// Returns the name of the object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hilolines.name?view=word-pia"/>
  public string Name { get; }

  /// <summary>
  /// Returns a border object that represents the high-low lines.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hilolines.border?view=word-pia"/>
  public ChartBorder Border { get; }

  /// <summary>
  /// Returns the chart format properties for the high-low lines.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hilolines.format?view=word-pia"/>
  public ChartFormat Format { get; }
}
