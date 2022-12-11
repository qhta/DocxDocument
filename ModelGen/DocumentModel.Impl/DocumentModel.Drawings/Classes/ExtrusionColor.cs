namespace DocumentModel.Drawings;

/// <summary>
/// Extrusion Color.
/// </summary>
public class ExtrusionColorImpl: DocumentModel.Drawings.ColorTypeImpl, ExtrusionColor
{
  public new DocumentFormat.OpenXml.Drawing.ExtrusionColor? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ExtrusionColor?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ExtrusionColorImpl(): base() {}
  
  public ExtrusionColorImpl(DocumentFormat.OpenXml.Drawing.ExtrusionColor openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new RgbColorModelPercentage? RgbColorModelPercentage
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new RgbColorModelHex? RgbColorModelHex
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new HslColor? HslColor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new SystemColor? SystemColor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new SchemeColor? SchemeColor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new PresetColor? PresetColor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
