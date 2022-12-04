namespace DocumentModel.Drawings;

/// <summary>
/// Data Model.
/// </summary>
public class DataModelRoot
{
  /// <summary>
  /// Point List.
  /// </summary>
  public PointList? PointList
  {
    get;
    set;
  }
  
  /// <summary>
  /// Connection List.
  /// </summary>
  public ConnectionList? ConnectionList
  {
    get;
    set;
  }
  
  /// <summary>
  /// Background Formatting.
  /// </summary>
  public Background? Background
  {
    get;
    set;
  }
  
  /// <summary>
  /// Whole E2O Formatting.
  /// </summary>
  public Whole? Whole
  {
    get;
    set;
  }
  
  /// <summary>
  /// DataModelExtensionList.
  /// </summary>
  public DataModelExtensionList? DataModelExtensionList
  {
    get;
    set;
  }
  
}
