namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Interface for run elements that can be included in paragraph and Sdt content run elements.
/// </summary>
public interface ICommonRunElement: IModelElement, IParagraphElement, ISdtRunElement
{
}