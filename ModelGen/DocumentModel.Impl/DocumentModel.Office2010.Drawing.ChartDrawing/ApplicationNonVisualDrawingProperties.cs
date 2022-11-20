namespace DocumentModel.Office2010.Drawing.ChartDrawing;

/// <summary>
/// Defines the ApplicationNonVisualDrawingProperties Class.
/// </summary>
public class ApplicationNonVisualDrawingProperties: IApplicationNonVisualDrawingProperties
{
  /// <summary>
  /// macro, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Macro
  {
    get;
    set;
  }
  
  /// <summary>
  /// fPublished, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? Published
  {
    get;
    set;
  }
  
}
