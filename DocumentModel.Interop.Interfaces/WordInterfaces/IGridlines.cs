namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents major or minor gridlines for a chart axis.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.gridlines?view=word-pia"/>
public interface IGridlines : IInteropObject
{
  /// <summary>
  /// Returns the name of the object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.gridlines.name?view=word-pia"/>
  public string Name { get; }

  /// <summary>
  /// Returns a border object that represents the border of the gridlines.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.gridlines.border?view=word-pia"/>
  public IChartBorder Border { get; }

  /// <summary>
  /// Returns the chart format properties for the gridlines.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.gridlines.format?view=word-pia"/>
  public IChartFormat Format { get; }


  #region methods

/// <summary>
  /// Selects the object.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.gridlines.select?view=word-pia"/>
  public object Select();

  #endregion methods
}
