namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the down bars in a chart group.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.downbars?view=word-pia"/>
public partial class DownBars : InteropObject
{
  /// <summary>
  /// Gets the name of the `DownBars` object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.downbars.name?view=word-pia"/>
  public string? Name { get; set; }

  /// <summary>
  /// Gets the border formatting for the down bars.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.downbars.border?view=word-pia"/>
  public ChartBorder Border { get; set; }

  /// <summary>
  /// Gets the interior formatting of the down bars.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.downbars.interior?view=word-pia"/>
  public Interior Interior { get; set; }

  /// <summary>
  /// Gets the fill formatting of the down bars.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.downbars.fill?view=word-pia"/>
  public ChartFillFormat Fill { get; set; }

  /// <summary>
  /// Gets the chart formatting for the down bars.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.downbars.format?view=word-pia"/>
  public ChartFormat Format { get; set; }


  #region methods

/// <summary>
  /// Returns the value produced by the select operation.
  /// </summary>
  /// <returns>The resulting value.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.downbars.select?view=word-pia"/>
  public object Select() { throw new NotImplementedException(); }

  #endregion methods
}
