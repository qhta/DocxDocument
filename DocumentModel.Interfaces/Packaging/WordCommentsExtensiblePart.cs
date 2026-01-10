using DocumentModel.Wordprocessing;
namespace DocumentModel.Packaging;

/// <summary>
///   Defines the WordCommentsExtensiblePart
/// </summary>
public interface WordCommentsExtensiblePart: OpenXmlPart
{
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public CommentsExtensible? CommentsExtensible { get; set; }


}