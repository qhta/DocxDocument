namespace DocumentModel.Drawings;

/// <summary>
/// Effect Reference.
/// </summary>
public class EffectReferenceImpl: DocumentModel.Drawings.StyleMatrixReferenceTypeImpl, EffectReference
{
  public new DocumentFormat.OpenXml.Drawing.EffectReference? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.EffectReference?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public EffectReferenceImpl(): base() {}
  
  public EffectReferenceImpl(DocumentFormat.OpenXml.Drawing.EffectReference openXmlElement): base(openXmlElement)
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
