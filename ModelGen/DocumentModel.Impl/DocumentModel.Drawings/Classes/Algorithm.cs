namespace DocumentModel.Drawings;

/// <summary>
/// Algorithm.
/// </summary>
public class AlgorithmImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Diagrams.Algorithm>, Algorithm
{
  /// <summary>
  /// Algorithm Type
  /// </summary>
  public AlgorithmKind? Type
  {
    get => (AlgorithmKind?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (DocumentFormat.OpenXml.Drawing.Diagrams.AlgorithmValues?)value;
    }
  }
  
  public ExtensionList3? ExtensionList
  {
    get;
    set;
  }
  
}
