namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the MathControlMoveType Class.
/// </summary>
public class MathControlMoveTypeImpl: ModelElementImpl, MathControlMoveType
{
  public DocumentFormat.OpenXml.Wordprocessing.MathControlMoveType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.MathControlMoveType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public MathControlMoveTypeImpl(): base() {}
  
  public MathControlMoveTypeImpl(DocumentFormat.OpenXml.Wordprocessing.MathControlMoveType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// author
  /// </summary>
  public String? Author
  {
    get => (String?)OpenXmlElement?.Author?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Author = (System.String?)value;
    }
  }
  
  /// <summary>
  /// date
  /// </summary>
  public DateTime? Date
  {
    get => (DateTime?)OpenXmlElement?.Date?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Date = (System.DateTime?)value;
    }
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  public String? Id
  {
    get => (String?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.String?)value;
    }
  }
  
}
