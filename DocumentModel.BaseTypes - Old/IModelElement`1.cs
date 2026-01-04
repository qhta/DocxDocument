namespace DocumentModel;

/// <summary>
///   Interface for model element that envelopes OpenXmlElement.
/// </summary>
public interface IModelElement<ElementType>: IModelElement
{
  public ElementType? _Element { get; set; }

  public ElementType _ExistingElement { get; }
}