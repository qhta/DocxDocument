namespace DocumentModel.Drawings;

/// <summary>
/// Defines the TrendlineLabel Class.
/// </summary>
public class TrendlineLabel2Impl: DocumentModel.Drawings.StyleEntryImpl, TrendlineLabel2
{
  public new DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TrendlineLabel? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TrendlineLabel?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public override LineReference2? LineReference
  {
    get;
    set;
  }
  
  public override String? LineWidthScale
  {
    get;
    set;
  }
  
  public override FillReference2? FillReference
  {
    get;
    set;
  }
  
  public override EffectReference1? EffectReference
  {
    get;
    set;
  }
  
  public override FontReference1? FontReference
  {
    get;
    set;
  }
  
  public override ShapeProperties4? ShapeProperties
  {
    get;
    set;
  }
  
  public override TextCharacterPropertiesType2? TextCharacterPropertiesType
  {
    get;
    set;
  }
  
  public override TextBodyProperties? TextBodyProperties
  {
    get;
    set;
  }
  
  public override OfficeArtExtensionList4? OfficeArtExtensionList
  {
    get;
    set;
  }
  
}
