namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a chart data table.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datatable?view=word-pia"/>
public partial interface DataTable : InteropObject
{
  /// <summary>
  /// The show legend key.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datatable.showlegendkey?view=word-pia"/>
  public bool ShowLegendKey { get; set; }

  /// <summary>
  /// The has border horizontal.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datatable.hasborderhorizontal?view=word-pia"/>
  public bool HasBorderHorizontal { get; set; }

  /// <summary>
  /// The has border vertical.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datatable.hasbordervertical?view=word-pia"/>
  public bool HasBorderVertical { get; set; }

  /// <summary>
  /// The has border outline.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datatable.hasborderoutline?view=word-pia"/>
  public bool HasBorderOutline { get; set; }

  /// <summary>
  /// The border.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datatable.border?view=word-pia"/>
  public ChartBorder Border { get; }

  /// <summary>
  /// The font.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datatable.font?view=word-pia"/>
  public ChartFont Font { get; }

  /// <summary>
  /// The auto scale font.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datatable.autoscalefont?view=word-pia"/>
  public object AutoScaleFont { get; set; }

  /// <summary>
  /// The format.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datatable.format?view=word-pia"/>
  public ChartFormat Format { get; }
}
