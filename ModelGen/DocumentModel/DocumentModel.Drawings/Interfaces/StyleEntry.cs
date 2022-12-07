namespace DocumentModel.Drawings;

/// <summary>
/// Defines the StyleEntry Class.
/// </summary>
public interface StyleEntry
{
  /// <summary>
  /// LineReference.
  /// </summary>
  public LineReference1? LineReference { get ; set; }
  
  /// <summary>
  /// FillReference.
  /// </summary>
  public FillReference1? FillReference { get ; set; }
  
  /// <summary>
  /// EffectReference.
  /// </summary>
  public EffectReference1? EffectReference { get ; set; }
  
  /// <summary>
  /// FontReference.
  /// </summary>
  public FontReference1? FontReference { get ; set; }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public ShapeProperties3? ShapeProperties { get ; set; }
  
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
  public OfficeArtExtensionList1? OfficeArtExtensionList { get ; set; }
  
}
