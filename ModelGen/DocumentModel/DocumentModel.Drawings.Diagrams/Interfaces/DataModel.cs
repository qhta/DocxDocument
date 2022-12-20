namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Data Model.
/// </summary>
public partial interface DataModel
{
  /// <summary>
  /// Point List.
  /// </summary>
  public DocumentModel.Drawings.Diagrams.PointList? PointList { get; set; }
  
  /// <summary>
  /// Connection List.
  /// </summary>
  public DocumentModel.Drawings.Diagrams.ConnectionList? ConnectionList { get; set; }
  
  /// <summary>
  /// Background Formatting.
  /// </summary>
  public DocumentModel.Drawings.Diagrams.Background? Background { get; set; }
  
  /// <summary>
  /// Whole E2O Formatting.
  /// </summary>
  public DocumentModel.Drawings.Diagrams.Whole? Whole { get; set; }
  
  /// <summary>
  /// DataModelExtensionList.
  /// </summary>
  public DocumentModel.Drawings.Diagrams.DataModelExtensionList? DataModelExtensionList { get; set; }
  
}
