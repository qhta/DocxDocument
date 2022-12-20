namespace DocumentModel.Vml;

/// <summary>
/// Shape Grouping History.
/// </summary>
public partial interface RegroupTable
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public DocumentModel.Vml.ExtensionHandlingBehaviorKind? Extension { get; set; }
  
  public Collection<DocumentModel.Vml.Entry>? Entries { get; set; }
  
}
