namespace DocumentModel.Drawings;

/// <summary>
/// Effect Reference.
/// </summary>
public class EffectReference2Impl: DocumentModel.Drawings.StyleMatrixReferenceTypeImpl, EffectReference2
{
  public new DocumentFormat.OpenXml.Drawing.EffectReference? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.EffectReference?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public override RgbColorModelPercentage? RgbColorModelPercentage
  {
    get;
    set;
  }
  
  public override RgbColorModelHex? RgbColorModelHex
  {
    get;
    set;
  }
  
  public override HslColor? HslColor
  {
    get;
    set;
  }
  
  public override SystemColor? SystemColor
  {
    get;
    set;
  }
  
  public override SchemeColor? SchemeColor
  {
    get;
    set;
  }
  
  public override PresetColor? PresetColor
  {
    get;
    set;
  }
  
}
