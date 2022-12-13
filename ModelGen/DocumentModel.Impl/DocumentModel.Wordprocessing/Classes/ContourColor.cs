namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ContourColor Class.
/// </summary>
public class ContourColorImpl: DocumentModel.Wordprocessing.ColorTypeImpl, ContourColor
{
  public new DocumentFormat.OpenXml.Office2010.Word.ContourColor? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Word.ContourColor?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ContourColorImpl(): base() {}
  
  public ContourColorImpl(DocumentFormat.OpenXml.Office2010.Word.ContourColor openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new DocumentModel.Wordprocessing.RgbColorModelHex? RgbColorModelHex
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new DocumentModel.Wordprocessing.SchemeColor? SchemeColor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
