namespace DocumentModel.Drawings;

/// <summary>
/// Defines the GridlineMinor Class.
/// </summary>
public class GridlineMinorImpl: DocumentModel.Drawings.StyleEntryImpl, GridlineMinor
{
  public new DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.GridlineMinor? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.GridlineMinor?)_OpenXmlElement;
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
