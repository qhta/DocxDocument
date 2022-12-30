namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the NumberFormat Class.
/// </summary>
public partial class NumberFormat
{
  /// <summary>
  /// formatCode, this property is only available in Office 2016 and later.
  /// </summary>
  public String? FormatCode { get; set; }
  
  /// <summary>
  /// sourceLinked, this property is only available in Office 2016 and later.
  /// </summary>
  public Boolean? SourceLinked { get; set; }
  
}
