namespace DocumentModel.Drawings;

/// <summary>
/// Accent 4.
/// </summary>
public class Accent4ColorImpl: DocumentModel.Drawings.Color2TypeImpl, Accent4Color
{
  public new DocumentFormat.OpenXml.Drawing.Accent4Color? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Accent4Color?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Accent4ColorImpl(): base() {}
  
  public Accent4ColorImpl(DocumentFormat.OpenXml.Drawing.Accent4Color openXmlElement): base(openXmlElement)
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
  
  public new DocumentModel.Drawings.PresetColor? PresetColor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
