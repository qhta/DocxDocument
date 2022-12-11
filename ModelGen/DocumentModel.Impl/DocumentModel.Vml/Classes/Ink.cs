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
  
  public InkImpl(): base() {}
  
  public InkImpl(DocumentFormat.OpenXml.Vml.Office.Ink openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Ink Data
  /// </summary>
  public Base64BinaryValue? InkData
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Annotation Flag
  /// </summary>
  public Boolean? AnnotationFlag
  {
    get => (Boolean?)OpenXmlElement?.AnnotationFlag?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.AnnotationFlag = (System.Boolean?)value;
    }
  }
  
}
