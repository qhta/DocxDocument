namespace DocumentModel.Drawings;

/// <summary>
/// Defines the StyleEntry Class.
/// </summary>
public class StyleEntryImpl: ModelElementImpl, StyleEntry
{
  public DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleEntry? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleEntry?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// mods, this property is only available in Office 2013 and later.
  /// </summary>
  public List<String>? Modifiers
  {
    get;
    set;
  }
  
  /// <summary>
  /// LineReference.
  /// </summary>
  public virtual LineReference2? LineReference
  {
    get;
    set;
  }
  
  /// <summary>
  /// LineWidthScale.
  /// </summary>
  public virtual String? LineWidthScale
  {
    get;
    set;
  }
  
  /// <summary>
  /// FillReference.
  /// </summary>
  public virtual FillReference2? FillReference
  {
    get;
    set;
  }
  
  /// <summary>
  /// EffectReference.
  /// </summary>
  public virtual EffectReference1? EffectReference
  {
    get;
    set;
  }
  
  /// <summary>
  /// FontReference.
  /// </summary>
  public virtual FontReference1? FontReference
  {
    get;
    set;
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public virtual ShapeProperties4? ShapeProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// TextCharacterPropertiesType.
  /// </summary>
  public virtual TextCharacterPropertiesType2? TextCharacterPropertiesType
  {
    get;
    set;
  }
  
  /// <summary>
  /// TextBodyProperties.
  /// </summary>
  public virtual TextBodyProperties? TextBodyProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public virtual OfficeArtExtensionList4? OfficeArtExtensionList
  {
    get;
    set;
  }
  
}
