namespace DocumentModel;

/// <summary>
///   Interface for all model elements.
/// </summary>
public interface IModelElement
{
  public ModelElement? Parent { get; set; }
}