namespace DocumentModel;

/// <summary>
///   Interface Ifor all model elements.
/// </summary>
public interface IModelElement
{
  /// <summary>
  /// Parent element of this model element.
  /// </summary>
  public ModelElement? Parent { get; set; }
}
