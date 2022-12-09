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
  
  public override RgbColorModelPercentage? RgbColorModelPercentage
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public override RgbColorModelHex? RgbColorModelHex
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public override HslColor? HslColor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public override SystemColor? SystemColor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public override SchemeColor? SchemeColor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public override PresetColor? PresetColor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
