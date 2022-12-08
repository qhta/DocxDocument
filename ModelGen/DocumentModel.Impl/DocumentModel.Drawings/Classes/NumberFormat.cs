namespace DocumentModel.Drawings;

/// <summary>
/// Defines the NumberFormat Class.
/// </summary>
public class NumberFormatImpl: ModelElementImpl, NumberFormat
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumberFormat? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumberFormat?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// formatCode, this property is only available in Office 2016 and later.
  /// </summary>
  public String? FormatCode
  {
    get;
    set;
  }
  
  /// <summary>
  /// sourceLinked, this property is only available in Office 2016 and later.
  /// </summary>
  public Boolean? SourceLinked
  {
    get;
    set;
  }
  
}
