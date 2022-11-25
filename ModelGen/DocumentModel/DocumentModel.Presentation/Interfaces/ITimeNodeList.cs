namespace DocumentModel.Presentation;

/// <summary>
/// Time Node List.
/// </summary>
public interface ITimeNodeList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// ParallelTimeNode.
  /// </summary>
  public DocumentModel.Presentation.IParallelTimeNode? ParallelTimeNode { get ; set; }
  
}
