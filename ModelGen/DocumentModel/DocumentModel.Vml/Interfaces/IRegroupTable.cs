namespace DocumentModel.Vml;

/// <summary>
/// Shape Grouping History.
/// </summary>
public interface IRegroupTable // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorKind? Extension { get ; set; }
  
  public Collection<IEntry>? Entries { get ; set; }
  
}
