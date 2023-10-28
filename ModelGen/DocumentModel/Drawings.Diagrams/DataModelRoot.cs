namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Data Model.
/// </summary>
public partial class DataModelRoot
{
  
  /// <summary>
  ///   Point List.
  /// </summary>
  public DMDD.PointList? PointList { get; set; }
  
  
  /// <summary>
  ///   Connection List.
  /// </summary>
  public DMDD.ConnectionList? ConnectionList { get; set; }
  
  
  /// <summary>
  ///   Background Formatting.
  /// </summary>
  public DMDD.Background? Background { get; set; }
  
  
  /// <summary>
  ///   Whole E2O Formatting.
  /// </summary>
  public DMDD.Whole? Whole { get; set; }
  
  
  /// <summary>
  ///   DataModelExtensionList.
  /// </summary>
  public DMDD.DataModelExtensionList? DataModelExtensionList { get; set; }
  
}
