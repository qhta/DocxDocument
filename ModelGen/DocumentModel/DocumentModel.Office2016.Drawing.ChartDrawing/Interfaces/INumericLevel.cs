namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the NumericLevel Class.
/// </summary>
public interface INumericLevel // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// ptCount, this property is only available in Office 2016 and later.
  /// </summary>
  public System.UInt32? PtCount { get ; set; }
  
  /// <summary>
  /// formatCode, this property is only available in Office 2016 and later.
  /// </summary>
  public System.String? FormatCode { get ; set; }
  
  /// <summary>
  /// name, this property is only available in Office 2016 and later.
  /// </summary>
  public System.String? Name { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Office2016.Drawing.ChartDrawing.INumericValue>? NumericValues { get ; set; }
  
}
