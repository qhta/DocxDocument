namespace DocumentModel.Vml;

/// <summary>
/// Shape Grouping History.
/// </summary>
public interface RegroupTable // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorKind? Extension { get ; set; }
  
  public Collection<Entry>? Entries { get ; set; }
  
}
