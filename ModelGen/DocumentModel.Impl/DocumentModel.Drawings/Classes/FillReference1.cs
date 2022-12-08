namespace DocumentModel.Drawings;

/// <summary>
/// Fill Reference.
/// </summary>
public class FillReference1Impl: DocumentModel.Drawings.StyleMatrixReferenceTypeImpl, FillReference1
{
  public new DocumentFormat.OpenXml.Drawing.FillReference? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.FillReference?)_OpenXmlElement;
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
