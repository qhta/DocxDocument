namespace DocumentModel.Drawings13.Charts;

/// <summary>
/// Defines the StyleEntry Class.
/// </summary>
public interface StyleEntry
{
  /// <summary>
  /// mods, this property is only available in Office 2013 and later.
  /// </summary>
  public List<System.String>? Modifiers { get ; set; }
  
  /// <summary>
  /// LineReference.
  /// </summary>
  public DocumentModel.Drawings13.Charts.LineReference? LineReference { get ; set; }
  
  /// <summary>
  /// LineWidthScale.
  /// </summary>
  public String? LineWidthScale { get ; set; }
  
  /// <summary>
  /// FillReference.
  /// </summary>
  public DocumentModel.Drawings13.Charts.FillReference? FillReference { get ; set; }
  
  /// <summary>
  /// EffectReference.
  /// </summary>
  public DocumentModel.Drawings13.Charts.EffectReference? EffectReference { get ; set; }
  
  /// <summary>
  /// FontReference.
  /// </summary>
  public DocumentModel.Drawings13.Charts.FontReference? FontReference { get ; set; }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public DocumentModel.Drawings13.Charts.ShapeProperties? ShapeProperties { get ; set; }
  
  /// <summary>
  /// TextCharacterPropertiesType.
  /// </summary>
  public DocumentModel.Drawings13.Charts.TextCharacterPropertiesType? TextCharacterPropertiesType { get ; set; }
  
  /// <summary>
  /// TextBodyProperties.
  /// </summary>
  public DocumentModel.Drawings13.Charts.TextBodyProperties? TextBodyProperties { get ; set; }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Drawings13.Charts.OfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
