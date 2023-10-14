namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the MultiLevelStringCache Class.
/// </summary>
public partial class MultiLevelStringCache
{
  
  /// <summary>
  ///   PointCount.
  /// </summary>
  public DocumentModel.Drawings.Charts.PointCount? PointCount { get; set; }
  
  public DocumentModel.Drawings.Charts.ExtensionList? ExtensionList { get; set; }
  
  public DM.ElementCollection<Level>? Items { get; set; }
  
}
