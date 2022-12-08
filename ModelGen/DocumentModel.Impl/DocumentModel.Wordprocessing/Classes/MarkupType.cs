namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the MarkupType Class.
/// </summary>
public class MarkupTypeImpl: ModelElementImpl, MarkupType
{
  public DocumentFormat.OpenXml.Office2010.Word.MarkupType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Word.MarkupType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  public String? Id
  {
    get;
    set;
  }
  
}
