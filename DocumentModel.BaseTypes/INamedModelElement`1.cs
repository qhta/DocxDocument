namespace DocumentModel;

/// <summary>
///   Interface for named model element that envelopes OpenXmlElement.
/// </summary>
public interface INamedModelElement<OpenXmlElementType>: IModelElement<OpenXmlElementType>
{
   public string? Name { get; set; }
}