namespace DocumentModel.Wordprocessing;

/// <summary>
/// Properties for a Single Font.
/// </summary>
public interface IFont // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// name
  /// </summary>
  public String? Name { get ; set; }
  
  /// <summary>
  /// AltName.
  /// </summary>
  public IAltName? AltName { get ; set; }
  
  /// <summary>
  /// Panose1Number.
  /// </summary>
  public IHexBinaryValue? Panose1Number { get ; set; }
  
  /// <summary>
  /// FontCharSet.
  /// </summary>
  public IFontCharSet? FontCharSet { get ; set; }
  
  /// <summary>
  /// FontFamily.
  /// </summary>
  public IEnumValue<DocumentFormat.OpenXml.Wordprocessing.FontFamilyValues>? FontFamily { get ; set; }
  
  /// <summary>
  /// NotTrueType.
  /// </summary>
  public INotTrueType? NotTrueType { get ; set; }
  
  /// <summary>
  /// Pitch.
  /// </summary>
  public IEnumValue<DocumentFormat.OpenXml.Wordprocessing.FontPitchValues>? Pitch { get ; set; }
  
  /// <summary>
  /// FontSignature.
  /// </summary>
  public IFontSignature? FontSignature { get ; set; }
  
  /// <summary>
  /// EmbedRegularFont.
  /// </summary>
  public IEmbedRegularFont? EmbedRegularFont { get ; set; }
  
  /// <summary>
  /// EmbedBoldFont.
  /// </summary>
  public IEmbedBoldFont? EmbedBoldFont { get ; set; }
  
  /// <summary>
  /// EmbedItalicFont.
  /// </summary>
  public IEmbedItalicFont? EmbedItalicFont { get ; set; }
  
  /// <summary>
  /// EmbedBoldItalicFont.
  /// </summary>
  public IEmbedBoldItalicFont? EmbedBoldItalicFont { get ; set; }
  
}
