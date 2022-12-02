namespace DocumentModel.Presentation;

/// <summary>
/// Time Node List.
/// </summary>
public interface ITimeNodeList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// ParallelTimeNode.
  /// </summary>
  public IParallelTimeNode? ParallelTimeNode { get ; set; }
  
}
