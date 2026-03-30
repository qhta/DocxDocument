namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Represents the border of an object.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartborder?view=word-pia"/>
public interface ChartBorder : IModelObject
{
  /// <summary>
  /// Gets or sets the primary color of the chart border.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartborder.color?view=word-pia"/>
  public object Color { get; set; }
  /// <summary>
  /// Gets or sets the color index for the chart border.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartborder.colorindex?view=word-pia"/>
  public object ColorIndex { get; set; }
  /// <summary>
  /// Gets or sets the line style of the chart border.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartborder.linestyle?view=word-pia"/>
  public object LineStyle { get; set; }
  /// <summary>
  /// Gets or sets the thickness of the chart border.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartborder.weight?view=word-pia"/>
  public object Weight { get; set; }

}
