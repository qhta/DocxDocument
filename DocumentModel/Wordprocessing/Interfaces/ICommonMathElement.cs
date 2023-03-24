using DocumentModel.Wordprocessing;

namespace DocumentModel.Math;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Interface for math elements that can be included in many other elements.
/// </summary>
public interface ICommonMathElement: IParagraphElement, ISdtRunElement
{
}