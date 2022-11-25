namespace DocumentModel.Vml.Office;

/// <summary>
/// Shape Grouping History.
/// </summary>
public interface IRegroupTable // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public DocumentModel.Vml.ExtensionHandlingBehaviorKind? Extension { get ; set; }
  
}
