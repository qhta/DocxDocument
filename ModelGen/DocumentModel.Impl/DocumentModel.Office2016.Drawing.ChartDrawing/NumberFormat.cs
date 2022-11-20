namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the NumberFormat Class.
/// </summary>
public class NumberFormat: INumberFormat
{
  /// <summary>
  /// formatCode, this property is only available in Office 2016 and later.
  /// </summary>
  public string? FormatCode
  {
    get;
    set;
  }
  
  /// <summary>
  /// sourceLinked, this property is only available in Office 2016 and later.
  /// </summary>
  public bool? SourceLinked
  {
    get;
    set;
  }
  
}
