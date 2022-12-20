namespace DocumentModel.Vml;

/// <summary>
/// Ink.
/// </summary>
public partial class InkImpl: ModelElementImpl, Ink
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
  public DocumentModel.Base64Binary? InkData
  {
    get
    {
      if (OpenXmlElement?.InkData?.Value != null)
        return (DocumentModel.Base64Binary)OpenXmlElement.InkData.Value;
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        if (value != null)
          OpenXmlElement.InkData = new DocumentFormat.OpenXml.Base64BinaryValue{ Value = value.ToString() };
        else
          OpenXmlElement.InkData = null;
      }
    }
  }
  
  /// <summary>
  /// Annotation Flag
  /// </summary>
  public Boolean? AnnotationFlag
  {
    get => (System.Boolean?)OpenXmlElement?.AnnotationFlag?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.AnnotationFlag = (System.Boolean?)value;
    }
  }
  
}
