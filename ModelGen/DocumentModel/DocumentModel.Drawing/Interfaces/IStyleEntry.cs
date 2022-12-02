namespace DocumentModel.Drawing;

/// <summary>
/// Defines the StyleEntry Class.
/// </summary>
public interface IStyleEntry // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// mods, this property is only available in Office 2013 and later.
  /// </summary>
  public System.Collections.Generic.List<System.String>? Modifiers { get ; set; }
  
  /// <summary>
  /// LineReference.
  /// </summary>
  public DocumentModel.Drawing.ILineReference? LineReference { get ; set; }
  
  /// <summary>
  /// LineWidthScale.
  /// </summary>
  public System.String? LineWidthScale { get ; set; }
  
  /// <summary>
  /// FillReference.
  /// </summary>
  public DocumentModel.Drawing.IFillReference? FillReference { get ; set; }
  
  /// <summary>
  /// EffectReference.
  /// </summary>
  public DocumentModel.Drawing.IEffectReference? EffectReference { get ; set; }
  
  /// <summary>
  /// FontReference.
  /// </summary>
  public DocumentModel.Drawing.IFontReference? FontReference { get ; set; }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public DocumentModel.Drawing.IShapeProperties? ShapeProperties { get ; set; }
  
  /// <summary>
  /// TextCharacterPropertiesType.
  /// </summary>
  public DocumentModel.Drawing.ITextCharacterPropertiesType? TextCharacterPropertiesType { get ; set; }
  
  /// <summary>
  /// TextBodyProperties.
  /// </summary>
  public DocumentModel.Drawing.ITextBodyProperties? TextBodyProperties { get ; set; }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Drawing.IOfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
