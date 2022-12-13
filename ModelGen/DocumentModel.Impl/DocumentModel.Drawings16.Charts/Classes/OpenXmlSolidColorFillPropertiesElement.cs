namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the OpenXmlSolidColorFillPropertiesElement Class.
/// </summary>
public class OpenXmlSolidColorFillPropertiesElementImpl: ModelElementImpl, OpenXmlSolidColorFillPropertiesElement
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OpenXmlSolidColorFillPropertiesElement? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OpenXmlSolidColorFillPropertiesElement?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public OpenXmlSolidColorFillPropertiesElementImpl(): base() {}
  
  public OpenXmlSolidColorFillPropertiesElementImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OpenXmlSolidColorFillPropertiesElement openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// RGB Color Model - Percentage Variant.
  /// </summary>
  public virtual DocumentModel.Drawings.RgbColorModelPercentage? RgbColorModelPercentage
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// RGB Color Model - Hex Variant.
  /// </summary>
  public virtual DocumentModel.Drawings.RgbColorModelHex? RgbColorModelHex
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Hue, Saturation, Luminance Color Model.
  /// </summary>
  public virtual DocumentModel.Drawings.HslColor? HslColor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// System Color.
  /// </summary>
  public virtual DocumentModel.Drawings.SystemColor? SystemColor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Scheme Color.
  /// </summary>
  public virtual DocumentModel.Drawings.SchemeColor? SchemeColor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Preset Color.
  /// </summary>
  public virtual DocumentModel.Drawings.PresetColor? PresetColor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
