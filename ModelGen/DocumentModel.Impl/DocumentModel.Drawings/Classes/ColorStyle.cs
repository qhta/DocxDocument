namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ColorStyle Class.
/// </summary>
public class ColorStyleImpl: ModelElementImpl, ColorStyle
{
  public DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ColorStyle? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ColorStyle?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ColorStyleImpl(): base() {}
  
  public ColorStyleImpl(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ColorStyle openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// meth, this property is only available in Office 2013 and later.
  /// </summary>
  public String? Method
  {
    get => (String?)OpenXmlElement?.Method?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Method = (System.String?)value;
    }
  }
  
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
  /// </summary>
  public UInt32? Id
  {
    get => (UInt32?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.UInt32?)value;
    }
  }
  
  public RgbColorModelPercentage? RgbColorModelPercentage
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public RgbColorModelHex? RgbColorModelHex
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public HslColor? HslColor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public SystemColor? SystemColor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public SchemeColor? SchemeColor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public PresetColor? PresetColor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<ColorStyleVariation>? ColorStyleVariations
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public OfficeArtExtensionList? OfficeArtExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
