namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ExtrusionColor Class.
/// </summary>
public class ExtrusionColorImpl: DocumentModel.Wordprocessing.ColorTypeImpl, ExtrusionColor
{
  public new DocumentFormat.OpenXml.Office2010.Word.ExtrusionColor? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Word.ExtrusionColor?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ExtrusionColorImpl(): base() {}
  
  public ExtrusionColorImpl(DocumentFormat.OpenXml.Office2010.Word.ExtrusionColor openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new RgbColorModelHex? RgbColorModelHex
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new SchemeColor? SchemeColor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
