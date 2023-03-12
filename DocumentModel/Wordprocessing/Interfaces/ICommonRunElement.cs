namespace DocumentModel.Wordprocessing;

/// <summary>
///   Interface for run elements that can be included in paragraph and Sdt content run elements.
/// </summary>
public interface ICommonRunElement: IModelElement, IParagraphElement, ISdtRunElement
{
}