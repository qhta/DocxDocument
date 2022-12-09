namespace DocumentModel.Drawings;

/// <summary>
/// Defines the StyleEntry Class.
/// </summary>
public interface StyleEntry
{
  /// <summary>
  /// mods, this property is only available in Office 2013 and later.
  /// </summary>
  public List<String>? Modifiers { get ; set; }
  
  /// <summary>
  /// LineReference.
  /// </summary>
  public LineReference1? LineReference { get ; set; }
  
  /// <summary>
  /// LineWidthScale.
  /// </summary>
  public String? LineWidthScale { get ; set; }
  
  /// <summary>
  /// FillReference.
  /// </summary>
  public FillReference2? FillReference { get ; set; }
  
  /// <summary>
  /// EffectReference.
  /// </summary>
  public EffectReference1? EffectReference { get ; set; }
  
  /// <summary>
  /// FontReference.
  /// </summary>
  public FontReference2? FontReference { get ; set; }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public ShapeProperties1? ShapeProperties { get ; set; }
  
  /// <summary>
  /// TextCharacterPropertiesType.
  /// </summary>
  public TextCharacterPropertiesType1? TextCharacterPropertiesType { get ; set; }
  
  /// <summary>
  /// TextBodyProperties.
  /// </summary>
  public TextBodyProperties? TextBodyProperties { get ; set; }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public OfficeArtExtensionList5? OfficeArtExtensionList { get ; set; }
  
}
