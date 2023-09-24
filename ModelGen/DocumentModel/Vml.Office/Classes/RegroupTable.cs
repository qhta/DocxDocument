namespace DocumentModel.Vml.Office;


/// <summary>
///   Shape Grouping History.
/// </summary>
public partial class RegroupTable
{
  
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorKind? Extension { get; set; }
  
  public ElementCollection<Entry>? Items { get; set; }
  
}
