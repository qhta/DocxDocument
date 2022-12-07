namespace DocumentModel.Drawings;

/// <summary>
/// Parameter.
/// </summary>
public class ParameterImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Diagrams.Parameter>, Parameter
{
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
  
}
