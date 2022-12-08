namespace DocumentModel.Drawings;

/// <summary>
/// Defines the MidColorSolidColorFillProperties Class.
/// </summary>
public class MidColorSolidColorFillPropertiesImpl: DocumentModel.Drawings.OpenXmlSolidColorFillPropertiesElementImpl, MidColorSolidColorFillProperties
{
  public new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MidColorSolidColorFillProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MidColorSolidColorFillProperties?)_OpenXmlElement;
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
