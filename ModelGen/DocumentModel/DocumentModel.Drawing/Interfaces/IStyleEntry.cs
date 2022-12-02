namespace DocumentModel.Drawing;

/// <summary>
/// Defines the StyleEntry Class.
/// </summary>
public interface IStyleEntry // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// mods, this property is only available in Office 2013 and later.
  /// </summary>
  public List<String>? Modifiers { get ; set; }
  
  /// <summary>
  /// LineReference.
  /// </summary>
  public ILineReference? LineReference { get ; set; }
  
  /// <summary>
  /// LineWidthScale.
  /// </summary>
  public String? LineWidthScale { get ; set; }
  
  /// <summary>
  /// FillReference.
  /// </summary>
  public IFillReference? FillReference { get ; set; }
  
  /// <summary>
  /// EffectReference.
  /// </summary>
  public IEffectReference? EffectReference { get ; set; }
  
  /// <summary>
  /// FontReference.
  /// </summary>
  public IFontReference? FontReference { get ; set; }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public IShapeProperties? ShapeProperties { get ; set; }
  
  /// <summary>
  /// TextCharacterPropertiesType.
  /// </summary>
  public ITextCharacterPropertiesType? TextCharacterPropertiesType { get ; set; }
  
  /// <summary>
  /// TextBodyProperties.
  /// </summary>
  public ITextBodyProperties? TextBodyProperties { get ; set; }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public IOfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
