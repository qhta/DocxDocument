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
    get => (UInt32?)OpenXmlElement?.Revision?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Revision = (System.UInt32?)value;
    }
  }
  
  public Collection<Parameter>? Parameters
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public ExtensionList1? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
