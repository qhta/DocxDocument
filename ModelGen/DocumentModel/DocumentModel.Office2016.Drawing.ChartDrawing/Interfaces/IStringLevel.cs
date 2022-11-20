namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the StringLevel Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IChartStringValue))]
public interface IStringLevel // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// ptCount, this property is only available in Office 2016 and later.
  /// </summary>
  public uint? PtCount { get ; set; }
  
  /// <summary>
  /// name, this property is only available in Office 2016 and later.
  /// </summary>
  public string? Name { get ; set; }
  
}
