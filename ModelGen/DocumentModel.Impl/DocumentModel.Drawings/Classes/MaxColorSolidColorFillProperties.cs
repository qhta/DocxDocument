namespace DocumentModel.Drawings;

/// <summary>
/// Defines the MaxColorSolidColorFillProperties Class.
/// </summary>
public class MaxColorSolidColorFillPropertiesImpl: DocumentModel.Drawings.OpenXmlSolidColorFillPropertiesElementImpl, MaxColorSolidColorFillProperties
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
