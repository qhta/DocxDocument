namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the NumericValue Class.
/// </summary>
public interface INumericValue // : DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement
{
  /// <summary>
  /// idx, this property is only available in Office 2016 and later.
  /// </summary>
  public uint? Idx { get ; set; }
  
  /// <summary>
  /// Gets or sets the text of the current element.
  /// </summary>
  public string? Text { get ; set; }
  
}
