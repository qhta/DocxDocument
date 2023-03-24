namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Interface for all model elements.
/// </summary>
public interface IModelElement
{
  public ModelElement? Parent { get; set; }
}