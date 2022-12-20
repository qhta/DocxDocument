namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the OpenXmlGridlinesElement Class.
/// </summary>
public partial interface OpenXmlGridlinesElement
{
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.ShapeProperties? ShapeProperties { get; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.ExtensionList? ExtensionList { get; set; }
  
}
