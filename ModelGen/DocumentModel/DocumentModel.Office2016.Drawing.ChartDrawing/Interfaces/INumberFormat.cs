namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the NumberFormat Class.
/// </summary>
public interface INumberFormat // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// formatCode, this property is only available in Office 2016 and later.
  /// </summary>
  public string? FormatCode { get ; set; }
  
  /// <summary>
  /// sourceLinked, this property is only available in Office 2016 and later.
  /// </summary>
  public bool? SourceLinked { get ; set; }
  
}
