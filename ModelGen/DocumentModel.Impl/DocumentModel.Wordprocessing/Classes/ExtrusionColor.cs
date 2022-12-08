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
  
  public override RgbColorModelHex? RgbColorModelHex
  {
    get;
    set;
  }
  
  public override SchemeColor? SchemeColor
  {
    get;
    set;
  }
  
}
