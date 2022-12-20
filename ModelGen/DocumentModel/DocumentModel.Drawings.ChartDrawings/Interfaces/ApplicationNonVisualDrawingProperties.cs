namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the ApplicationNonVisualDrawingProperties Class.
/// </summary>
public partial interface ApplicationNonVisualDrawingProperties
{
  /// <summary>
  /// macro, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Macro { get; set; }
  
  /// <summary>
  /// fPublished, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? Published { get; set; }
  
}
