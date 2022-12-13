namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the BubbleSize Class.
/// </summary>
public class BubbleSizeImpl: DocumentModel.Drawings.Charts.NumberDataSourceTypeImpl, BubbleSize
{
  public new DocumentFormat.OpenXml.Drawing.Charts.BubbleSize? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.BubbleSize?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public BubbleSizeImpl(): base() {}
  
  public BubbleSizeImpl(DocumentFormat.OpenXml.Drawing.Charts.BubbleSize openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new DocumentModel.Drawings.Charts.NumberReference? NumberReference
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new DocumentModel.Drawings.Charts.NumberLiteral? NumberLiteral
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
