namespace DocumentModel.Drawings;

/// <summary>
/// Custom Split.
/// </summary>
public class CustomSplitImpl: ModelElementImpl, CustomSplit
{
  public DocumentFormat.OpenXml.Drawing.Charts.CustomSplit? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.CustomSplit?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<UInt32>? SecondPiePoints
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
