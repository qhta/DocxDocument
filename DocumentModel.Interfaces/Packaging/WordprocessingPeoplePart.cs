using DocumentModel.Wordprocessing;
namespace DocumentModel.Packaging;

/// <summary>
///   Defines the WordprocessingPeoplePart
/// </summary>
public interface WordprocessingPeoplePart: OpenXmlPart
{

  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public People? People { get; set; }

}