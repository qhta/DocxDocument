namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines Styles.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IDocDefaults))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ILatentStyles))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IStyle))]
public class Styles: IStyles
{
  /// <summary>
  /// Document Default Paragraph and Run Properties.
  /// </summary>
  public IDocDefaults? DocDefaults
  {
    get;
    set;
  }
  
  /// <summary>
  /// Latent Style Information.
  /// </summary>
  public ILatentStyles? LatentStyles
  {
    get;
    set;
  }
  
}
