namespace DocumentModel.Drawings.ChartsStyle;

/// <summary>
/// Defines the StyleEntry Class.
/// </summary>
public partial interface StyleEntry
{
  /// <summary>
  /// mods, this property is only available in Office 2013 and later.
  /// </summary>
  public DocumentModel.ListOf<System.String>? Modifiers { get; set; }
  
  /// <summary>
  /// LineReference.
  /// </summary>
  public DocumentModel.Drawings.ChartsStyle.LineReference? LineReference { get; set; }
  
  /// <summary>
  /// LineWidthScale.
  /// </summary>
  public String? LineWidthScale { get; set; }
  
  /// <summary>
  /// FillReference.
  /// </summary>
  public DocumentModel.Drawings.ChartsStyle.FillReference? FillReference { get; set; }
  
  /// <summary>
  /// EffectReference.
  /// </summary>
  public DocumentModel.Drawings.ChartsStyle.EffectReference? EffectReference { get; set; }
  
  /// <summary>
  /// FontReference.
  /// </summary>
  public DocumentModel.Drawings.ChartsStyle.FontReference? FontReference { get; set; }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public DocumentModel.Drawings.ChartsStyle.ShapeProperties? ShapeProperties { get; set; }
  
  /// <summary>
  /// TextCharacterPropertiesType.
  /// </summary>
  public DocumentModel.Drawings.ChartsStyle.TextCharacterPropertiesType? TextCharacterPropertiesType { get; set; }
  
  /// <summary>
  /// TextBodyProperties.
  /// </summary>
  public DocumentModel.Drawings.ChartsStyle.TextBodyProperties? TextBodyProperties { get; set; }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Drawings.ChartsStyle.OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
  
}
