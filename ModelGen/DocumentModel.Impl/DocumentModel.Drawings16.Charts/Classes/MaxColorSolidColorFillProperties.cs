namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the MaxColorSolidColorFillProperties Class.
/// </summary>
public class MaxColorSolidColorFillPropertiesImpl: DocumentModel.Drawings16.Charts.OpenXmlSolidColorFillPropertiesElementImpl, MaxColorSolidColorFillProperties
{
  public new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MaxColorSolidColorFillProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MaxColorSolidColorFillProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public MaxColorSolidColorFillPropertiesImpl(): base() {}
  
  public MaxColorSolidColorFillPropertiesImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MaxColorSolidColorFillProperties openXmlElement): base(openXmlElement)
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
