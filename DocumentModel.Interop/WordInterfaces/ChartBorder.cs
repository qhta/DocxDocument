namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the border of an object.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartborder?view=word-pia"/>
public interface ChartBorder : InteropObject
{
  /// <summary>
  /// The color.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartborder.color?view=word-pia"/>
  public object Color { get; set; }
  /// <summary>
  /// The color index.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartborder.colorindex?view=word-pia"/>
  public object ColorIndex { get; set; }
  /// <summary>
  /// The line style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartborder.linestyle?view=word-pia"/>
  public object LineStyle { get; set; }
  /// <summary>
  /// The weight.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartborder.weight?view=word-pia"/>
  public object Weight { get; set; }

}
