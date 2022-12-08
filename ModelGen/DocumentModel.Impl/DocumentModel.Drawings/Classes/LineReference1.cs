namespace DocumentModel.Drawings;

/// <summary>
/// Defines the LineReference Class.
/// </summary>
public class LineReference1Impl: DocumentModel.Drawings.StyleMatrixReferenceTypeImpl, LineReference1
{
  public new DocumentFormat.OpenXml.Drawing.LineReference? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.LineReference?)_OpenXmlElement;
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
