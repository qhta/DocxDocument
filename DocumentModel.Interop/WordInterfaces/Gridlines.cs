namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents major or minor gridlines for a chart axis.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.gridlines?view=word-pia"/>
public partial interface IGridlines : IInteropObject
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
  public ChartBorder Border { get; }

  /// <summary>
  /// Returns the chart format properties for the gridlines.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.gridlines.format?view=word-pia"/>
  public ChartFormat Format { get; }
}
