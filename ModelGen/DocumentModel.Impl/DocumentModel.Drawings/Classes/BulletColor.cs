namespace DocumentModel.Drawings;

/// <summary>
/// Color Specified.
/// </summary>
public class BulletColorImpl: DocumentModel.Drawings.ColorTypeImpl, BulletColor
{
  public new DocumentFormat.OpenXml.Drawing.BulletColor? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.BulletColor?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public BulletColorImpl(): base() {}
  
  public BulletColorImpl(DocumentFormat.OpenXml.Drawing.BulletColor openXmlElement): base(openXmlElement)
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
