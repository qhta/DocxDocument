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
  
  /// <summary>
  /// Parameter Type
  /// </summary>
  public ParameterIdKind? Type
  {
    get => (ParameterIdKind?)OpenXmlElement?.Type?.Value;
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
    get => (String?)OpenXmlElement?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Val = (System.String?)value;
    }
  }
  
}
