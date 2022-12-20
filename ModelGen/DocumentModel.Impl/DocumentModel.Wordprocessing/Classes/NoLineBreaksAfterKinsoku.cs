namespace DocumentModel.Wordprocessing;

/// <summary>
/// Custom Set of Characters Which Cannot End a Line.
/// </summary>
public partial class NoLineBreaksAfterKinsokuImpl: ModelElementImpl, NoLineBreaksAfterKinsoku
{
  public DocumentFormat.OpenXml.Wordprocessing.NoLineBreaksAfterKinsoku? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.NoLineBreaksAfterKinsoku?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public NoLineBreaksAfterKinsokuImpl(): base() {}
  
  public NoLineBreaksAfterKinsokuImpl(DocumentFormat.OpenXml.Wordprocessing.NoLineBreaksAfterKinsoku openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// lang
  /// </summary>
  public String? Language
  {
    get => (System.String?)OpenXmlElement?.Language?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Language = (System.String?)value;
    }
  }
  
  /// <summary>
  /// val
  /// </summary>
  public String? Val
  {
    get => (System.String?)OpenXmlElement?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Val = (System.String?)value;
    }
  }
  
}
