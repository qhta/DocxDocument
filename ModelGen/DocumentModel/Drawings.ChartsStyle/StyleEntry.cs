namespace DocumentModel.Drawings.ChartsStyle;


/// <summary>
///   Defines the StyleEntry Class.
/// </summary>
public partial class StyleEntry
{
  
  /// <summary>
  ///   mods, this property is only available in Office 2013 and later.
  /// </summary>
  public DM.ListOf<String>? Modifiers { get; set; }
  
  
  /// <summary>
  ///   LineReference.
  /// </summary>
  public DMDCS.LineReference? LineReference { get; set; }
  
  
  /// <summary>
  ///   LineWidthScale.
  /// </summary>
  public DMDCS.LineWidthScale? LineWidthScale { get; set; }
  
  
  /// <summary>
  ///   FillReference.
  /// </summary>
  public DMDCS.FillReference? FillReference { get; set; }
  
  
  /// <summary>
  ///   EffectReference.
  /// </summary>
  public DMDCS.EffectReference? EffectReference { get; set; }
  
  
  /// <summary>
  ///   FontReference.
  /// </summary>
  public DMDCS.FontReference? FontReference { get; set; }
  
  
  /// <summary>
  ///   ShapeProperties.
  /// </summary>
  public DMDCS.ShapeProperties? ShapeProperties { get; set; }
  
  
  /// <summary>
  ///   TextCharacterPropertiesType.
  /// </summary>
  public DMDCS.TextCharacterPropertiesType? TextCharacterPropertiesType { get; set; }
  
  
  /// <summary>
  ///   TextBodyProperties.
  /// </summary>
  public DMDCS.TextBodyProperties? TextBodyProperties { get; set; }
  
  
  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  public DMDCS.OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
  
}
