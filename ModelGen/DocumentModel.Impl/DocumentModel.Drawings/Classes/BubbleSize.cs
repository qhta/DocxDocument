namespace DocumentModel.Drawings;

/// <summary>
/// Defines the BubbleSize Class.
/// </summary>
public class BubbleSizeImpl: DocumentModel.Drawings.NumberDataSourceTypeImpl, BubbleSize
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
  
  public new NumberReference? NumberReference
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new NumberLiteral? NumberLiteral
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
