namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the error bars on a chart series.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.errorbars?view=word-pia"/>
public interface IErrorBars : IInteropObject
{
  /// <summary>
  /// Gets the name of the `ErrorBars` object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.errorbars.name?view=word-pia"/>
  public string Name { get; }

  /// <summary>
  /// Gets the border formatting for the error bars.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.errorbars.border?view=word-pia"/>
  public IChartBorder Border { get; }

  /// <summary>
  /// Gets or sets the cap style for the ends of the error bars.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.errorbars.endstyle?view=word-pia"/>
  public EndStyleCap EndStyle { get; set; }

  /// <summary>
  /// Gets the chart formatting for the error bars.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.errorbars.format?view=word-pia"/>
  public IChartFormat Format { get; }


  #region methods

/// <summary>
  /// Returns the value produced by the select operation.
  /// </summary>
  /// <returns>The resulting value.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.errorbars.select?view=word-pia"/>
  public object Select();

  #endregion methods
}
