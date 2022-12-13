namespace DocumentModel.Drawings;

/// <summary>
/// Accent 6.
/// </summary>
public class Accent6ColorImpl: DocumentModel.Drawings.Color2TypeImpl, Accent6Color
{
  public new DocumentFormat.OpenXml.Drawing.Accent6Color? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Accent6Color?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Accent6ColorImpl(): base() {}
  
  public Accent6ColorImpl(DocumentFormat.OpenXml.Drawing.Accent6Color openXmlElement): base(openXmlElement)
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
