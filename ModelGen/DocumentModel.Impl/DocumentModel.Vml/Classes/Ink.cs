namespace DocumentModel.Vml;

/// <summary>
/// Ink.
/// </summary>
public class InkImpl: ModelElementImpl, Ink
{
  public DocumentFormat.OpenXml.Vml.Office.Ink? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Vml.Office.Ink?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Ink Data
  /// </summary>
  public DocumentModel.Base64BinaryValue? InkData
  {
    get;
    set;
  }
  
  /// <summary>
  /// Annotation Flag
  /// </summary>
  public Boolean? AnnotationFlag
  {
    get;
    set;
  }
  
}
