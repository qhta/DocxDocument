namespace DocumentModel.Wordprocessing;

/// <summary>
///   This element specifies the background for every page of the document containing the background element. 
///   A document's background is the image or fill for the entire page surface, behind all other document content.
/// </summary>
public class DocumentBackground: ModelElement
{
  /// <summary>
  ///   Specifies the color for the background of the document.
  /// </summary>
  public DM.Color? Color { get; set; }

  /// <summary>
  ///   Background.
  /// </summary>
  public DMV.Background? Background { get; set; }
}