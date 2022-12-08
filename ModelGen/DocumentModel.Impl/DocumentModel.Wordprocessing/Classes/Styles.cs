namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines Styles.
/// </summary>
public class StylesImpl: ModelElementImpl, Styles
{
  public DocumentFormat.OpenXml.Wordprocessing.Styles? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.Styles?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Document Default Paragraph and Run Properties.
  /// </summary>
  public DocDefaults? DocDefaults
  {
    get;
    set;
  }
  
  /// <summary>
  /// Latent Style Information.
  /// </summary>
  public LatentStyles? LatentStyles
  {
    get;
    set;
  }
  
  public Collection<Style>? Items
  {
    get;
    set;
  }
  
}
