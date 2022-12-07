namespace DocumentModel.Drawings;

/// <summary>
/// Defines the StyleEntry Class.
/// </summary>
public class StyleEntryImpl: ModelElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleEntry>, StyleEntry
{
  /// <summary>
  /// LineReference.
  /// </summary>
  public virtual LineReference1? LineReference
  {
    get;
    set;
  }
  
  /// <summary>
  /// FillReference.
  /// </summary>
  public virtual FillReference1? FillReference
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
  public virtual ShapeProperties3? ShapeProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// TextCharacterPropertiesType.
  /// </summary>
  public virtual TextCharacterPropertiesType1? TextCharacterPropertiesType
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
  public virtual OfficeArtExtensionList1? OfficeArtExtensionList
  {
    get;
    set;
  }
  
}
