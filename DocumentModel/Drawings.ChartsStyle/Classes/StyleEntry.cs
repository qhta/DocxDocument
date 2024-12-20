namespace DocumentModel.Drawings.ChartsStyle;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the StyleEntry Class.
/// </summary>
public class StyleEntry: ModelElement
{
  /// <summary>
  ///   mods, this property is only available in Office 2013 and later.
  /// </summary>
  public ListOf<String>? Modifiers { get; set; }

  /// <summary>
  ///   LineReference.
  /// </summary>
  public LineReference? LineReference { get; set; }

  /// <summary>
  ///   LineWidthScale.
  /// </summary>
  public string? LineWidthScale { get; set; }

  /// <summary>
  ///   FillReference.
  /// </summary>
  public FillReference? FillReference { get; set; }

  /// <summary>
  ///   EffectReference.
  /// </summary>
  public EffectReference? EffectReference { get; set; }

  /// <summary>
  ///   FontReference.
  /// </summary>
  public FontReference? FontReference { get; set; }

  /// <summary>
  ///   ShapeProperties.
  /// </summary>
  public ShapeProperties? ShapeProperties { get; set; }

  /// <summary>
  ///   TextCharacterPropertiesType.
  /// </summary>
  public TextCharacterPropertiesType? TextCharacterPropertiesType { get; set; }

  /// <summary>
  ///   TextBodyProperties.
  /// </summary>
  public TextBodyProperties? TextBodyProperties { get; set; }

  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  public OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
}