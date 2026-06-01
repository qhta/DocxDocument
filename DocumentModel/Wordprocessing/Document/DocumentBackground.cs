namespace DocumentModel.Wordprocessing;

/// <summary>
///   This element specifies the background Ifor every page of the document containing the background element. 
///   A document's background is the image or fill Ifor the entire page surface, behind all other document content.
/// </summary>
public class DocumentBackground: ModelElement
{
  /// <summary>
  ///   Specifies the color Ifor the background of the document.
  /// </summary>
  public DM.Color? Color { get; set; }

  /// <summary>
  ///   Background.
  /// </summary>
  public DMV.Background? Background { get; set; }
}
