namespace DocumentModel.Spreadsheet.Drawings;

/// <summary>
/// Defines the ApplicationNonVisualDrawingProperties Class.
/// </summary>
public interface ApplicationNonVisualDrawingProperties // : System.Boolean
{
  /// <summary>
  /// macro, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Macro { get ; set; }
  
  /// <summary>
  /// fPublished, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? PublishedFlag { get ; set; }
  
}
