namespace DocumentModel.Drawings;

/// <summary>
/// Parameter.
/// </summary>
public class ParameterImpl: ModelElementImpl, Parameter
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.Parameter? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.Parameter?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ParameterImpl(): base() {}
  
  public ParameterImpl(DocumentFormat.OpenXml.Drawing.Diagrams.Parameter openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Parameter Type
  /// </summary>
  public DocumentModel.Drawings.ParameterIdKind? Type
  {
    get => (DocumentModel.Drawings.ParameterIdKind?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (DocumentFormat.OpenXml.Drawing.Diagrams.ParameterIdValues?)value;
    }
  }
  
  /// <summary>
  /// Value
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
