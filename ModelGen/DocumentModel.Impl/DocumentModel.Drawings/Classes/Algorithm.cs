namespace DocumentModel.Drawings;

/// <summary>
/// Algorithm.
/// </summary>
public class AlgorithmImpl: ModelElementImpl, Algorithm
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.Algorithm? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.Algorithm?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
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
  
  /// <summary>
  /// Revision Number
  /// </summary>
  public UInt32? Revision
  {
    get;
    set;
  }
  
  public Collection<Parameter>? Parameters
  {
    get;
    set;
  }
  
  public ExtensionList3? ExtensionList
  {
    get;
    set;
  }
  
}
