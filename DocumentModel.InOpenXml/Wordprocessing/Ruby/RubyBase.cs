using DocumentModel.Math;
namespace DocumentModel.Wordprocessing;

  /// <summary>
  /// Represents the base text for a phonetic guide (ruby text) in WordprocessingML documents.
  /// This class is used as the base text over which phonetic guide text (ruby) is displayed, enabling pronunciation aids and language learning features for East Asian scripts and other scenarios requiring phonetic annotation.
  /// </summary>
  public class RubyBase : ModelElement<DXW.RubyBase>, IRubyContent
  {
  }