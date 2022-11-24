namespace DocumentModel.Presentation;

/// <summary>
/// Parallel Time Node.
/// </summary>
public interface IParallelTimeNode // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Parallel TimeNode.
  /// </summary>
  public ICommonTimeNode? CommonTimeNode { get ; set; }
  
}
