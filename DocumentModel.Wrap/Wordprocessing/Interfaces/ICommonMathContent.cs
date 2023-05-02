using DocumentModel.Wordprocessing;

namespace DocumentModel.Math;

/// <summary>
///   Interface for math elements that can be included in many other elements.
/// </summary>
public interface ICommonMathContent: 
  IParagraphContent, 
  ISdtRunContent, 
  IRubyContent,
  IBidirectionalContent, 
  IMathArgumentContent, 
  IOfficeMathContent, 
  IMathParagraphContent
{
}