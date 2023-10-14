namespace DocumentModel.Vml.Office;


/// <summary>
///   Shape Grouping History.
/// </summary>
public partial class RegroupTable
{
  
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  public DocumentModel.Vml.ExtensionHandlingBehaviorKind? Extension { get; set; }
  
  public DM.ElementCollection<Entry>? Items { get; set; }
  
}
