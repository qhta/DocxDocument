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
  
  public override NumberReference? NumberReference
  {
    get;
    set;
  }
  
  public override NumberLiteral? NumberLiteral
  {
    get;
    set;
  }
  
}
