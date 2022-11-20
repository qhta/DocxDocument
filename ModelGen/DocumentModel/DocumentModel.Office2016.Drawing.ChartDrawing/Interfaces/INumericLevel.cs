namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the NumericLevel Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.INumericValue))]
public interface INumericLevel // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// ptCount, this property is only available in Office 2016 and later.
  /// </summary>
  public uint? PtCount { get ; set; }
  
  /// <summary>
  /// formatCode, this property is only available in Office 2016 and later.
  /// </summary>
  public string? FormatCode { get ; set; }
  
  /// <summary>
  /// name, this property is only available in Office 2016 and later.
  /// </summary>
  public string? Name { get ; set; }
  
}
