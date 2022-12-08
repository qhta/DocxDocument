namespace DocumentModel.Drawings;

/// <summary>
/// Duotone Effect.
/// </summary>
public class DuotoneImpl: ModelElementImpl, Duotone
{
  public DocumentFormat.OpenXml.Drawing.Duotone? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Duotone?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<RgbColorModelPercentage>? RgbColorModelPercentages
  {
    get;
    set;
  }
  
  public Collection<RgbColorModelHex>? RgbColorModelHexs
  {
    get;
    set;
  }
  
  public Collection<HslColor>? HslColors
  {
    get;
    set;
  }
  
  public Collection<SystemColor>? SystemColors
  {
    get;
    set;
  }
  
  public Collection<SchemeColor>? SchemeColors
  {
    get;
    set;
  }
  
  public Collection<PresetColor>? PresetColors
  {
    get;
    set;
  }
  
}
