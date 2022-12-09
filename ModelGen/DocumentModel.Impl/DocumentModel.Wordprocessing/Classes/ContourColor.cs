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
  
  public override RgbColorModelHex? RgbColorModelHex
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public override SchemeColor? SchemeColor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
