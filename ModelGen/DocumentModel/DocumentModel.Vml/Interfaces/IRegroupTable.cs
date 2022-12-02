namespace DocumentModel.Vml;

/// <summary>
/// Shape Grouping History.
/// </summary>
public interface IRegroupTable // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public DocumentModel.Vml.ExtensionHandlingBehaviorKind? Extension { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Vml.IEntry>? Entries { get ; set; }
  
}
