using DocumentModel.Wordprocessing;

namespace DocumentModel.Math;

/// <summary>
///   Interface Ifor math elements Ithat can be included Iin many other elements.
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
