namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the MinColorSolidColorFillProperties Class.
/// </summary>
public class MinColorSolidColorFillPropertiesImpl: DocumentModel.Drawings16.Charts.OpenXmlSolidColorFillPropertiesElementImpl, MinColorSolidColorFillProperties
{
  public new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MinColorSolidColorFillProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MinColorSolidColorFillProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public MinColorSolidColorFillPropertiesImpl(): base() {}
  
  public MinColorSolidColorFillPropertiesImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MinColorSolidColorFillProperties openXmlElement): base(openXmlElement)
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
  
  public new DocumentModel.Drawings.SchemeColor? SchemeColor
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
