namespace DocumentModel.Office2010.Excel.Drawing;

/// <summary>
/// Defines the ApplicationNonVisualDrawingProperties Class.
/// </summary>
public interface IApplicationNonVisualDrawingProperties // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// macro, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Macro { get ; set; }
  
  /// <summary>
  /// fPublished, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? PublishedFlag { get ; set; }
  
}
