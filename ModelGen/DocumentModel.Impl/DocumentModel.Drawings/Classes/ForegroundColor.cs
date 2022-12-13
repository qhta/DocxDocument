namespace DocumentModel.Drawings;

/// <summary>
/// Foreground color.
/// </summary>
public class ForegroundColorImpl: DocumentModel.Drawings.ColorTypeImpl, ForegroundColor
{
  public new DocumentFormat.OpenXml.Drawing.ForegroundColor? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ForegroundColor?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ForegroundColorImpl(): base() {}
  
  public ForegroundColorImpl(DocumentFormat.OpenXml.Drawing.ForegroundColor openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new DocumentModel.Drawings.RgbColorModelPercentage? RgbColorModelPercentage
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new DocumentModel.Drawings.RgbColorModelHex? RgbColorModelHex
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new DocumentModel.Drawings.HslColor? HslColor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new DocumentModel.Drawings.SystemColor? SystemColor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new DocumentModel.Drawings.SchemeColor? SchemeColor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new DocumentModel.Drawings.PresetColor? PresetColor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
