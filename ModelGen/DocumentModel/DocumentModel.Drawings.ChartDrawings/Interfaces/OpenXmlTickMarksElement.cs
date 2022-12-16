namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the OpenXmlTickMarksElement Class.
/// </summary>
public interface OpenXmlTickMarksElement
{
  /// <summary>
  /// type, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.TickMarksType? Type { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.ExtensionList? ExtensionList { get ; set; }
  
}
