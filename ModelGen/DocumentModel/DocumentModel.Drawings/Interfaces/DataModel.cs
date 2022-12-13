namespace DocumentModel.Drawings;

/// <summary>
/// Data Model.
/// </summary>
public interface DataModel
{
  /// <summary>
  /// Point List.
  /// </summary>
  public DocumentModel.Drawings.PointList? PointList { get ; set; }
  
  /// <summary>
  /// Connection List.
  /// </summary>
  public DocumentModel.Drawings.ConnectionList? ConnectionList { get ; set; }
  
  /// <summary>
  /// Background Formatting.
  /// </summary>
  public DocumentModel.Drawings.Background? Background { get ; set; }
  
  /// <summary>
  /// Whole E2O Formatting.
  /// </summary>
  public DocumentModel.Drawings.Whole? Whole { get ; set; }
  
  /// <summary>
  /// DataModelExtensionList.
  /// </summary>
  public DocumentModel.Drawings.DataModelExtensionList? DataModelExtensionList { get ; set; }
  
}
