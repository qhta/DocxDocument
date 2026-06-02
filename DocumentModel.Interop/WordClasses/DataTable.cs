namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a chart data table.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datatable?view=word-pia"/>
public partial class DataTable : InteropObject
{
  /// <summary>
  /// Gets or sets a value indicating whether legend keys are shown in the data table.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datatable.showlegendkey?view=word-pia"/>
  public bool ShowLegendKey { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether horizontal borders are shown in the data table.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datatable.hasborderhorizontal?view=word-pia"/>
  public bool HasBorderHorizontal { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether vertical borders are shown in the data table.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datatable.hasbordervertical?view=word-pia"/>
  public bool HasBorderVertical { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether an outline border is shown around the data table.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datatable.hasborderoutline?view=word-pia"/>
  public bool HasBorderOutline { get; set; }

  /// <summary>
  /// Gets the border formatting for the data table.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datatable.border?view=word-pia"/>
  public ChartBorder Border { get; set; }

  /// <summary>
  /// Gets the font formatting for the data table.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datatable.font?view=word-pia"/>
  public ChartFont Font { get; set; }

  /// <summary>
  /// Gets or sets whether the font size is scaled automatically.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datatable.autoscalefont?view=word-pia"/>
  public object AutoScaleFont { get; set; }

  /// <summary>
  /// Gets the chart formatting for the data table.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datatable.format?view=word-pia"/>
  public ChartFormat Format { get; set; }


  #region methods

/// <summary>
  /// Selects the object.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.datatable.select?view=word-pia"/>
  public void Select() { throw new NotImplementedException(); }

  #endregion methods
}
