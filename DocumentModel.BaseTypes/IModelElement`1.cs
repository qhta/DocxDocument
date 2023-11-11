namespace DocumentModel;

/// <summary>
///   Interface for model element that envelopes OpenXmlElement.
/// </summary>
public interface IModelElement<OpenXmlElementType>: IModelElement
{
  public OpenXmlElementType? _Element { get; set; }

  public OpenXmlElementType _ExistingElement { get; }
}