namespace DocumentModel.Vml;


/// <summary>
///   Defines the ImageData Class.
/// </summary>
public partial class ImageData
{
  
  /// <summary>
  ///   Unique Identifier
  /// </summary>
  [SchemaAttr("id")]
  public String? Id { get; set; }
  
  
  /// <summary>
  ///   Image Transparency Color
  /// </summary>
  [SchemaAttr("chromakey")]
  public String? ChromAKey { get; set; }
  
  
  /// <summary>
  ///   Image Left Crop
  /// </summary>
  [SchemaAttr("cropleft")]
  public String? CropLeft { get; set; }
  
  
  /// <summary>
  ///   Image Top Crop
  /// </summary>
  [SchemaAttr("croptop")]
  public String? CropTop { get; set; }
  
  
  /// <summary>
  ///   Image Right Crop
  /// </summary>
  [SchemaAttr("cropright")]
  public String? CropRight { get; set; }
  
  
  /// <summary>
  ///   Image Bottom Crop
  /// </summary>
  [SchemaAttr("cropbottom")]
  public String? CropBottom { get; set; }
  
  
  /// <summary>
  ///   Image Intensity
  /// </summary>
  [SchemaAttr("gain")]
  public String? Gain { get; set; }
  
  
  /// <summary>
  ///   Image Brightness
  /// </summary>
  [SchemaAttr("blacklevel")]
  public String? BlackLevel { get; set; }
  
  
  /// <summary>
  ///   Image Gamma Correction
  /// </summary>
  [SchemaAttr("gamma")]
  public String? Gamma { get; set; }
  
  
  /// <summary>
  ///   Image Grayscale Toggle
  /// </summary>
  [SchemaAttr("grayscale")]
  public Boolean? Grayscale { get; set; }
  
  
  /// <summary>
  ///   Image Bilevel Toggle
  /// </summary>
  [SchemaAttr("bilevel")]
  public Boolean? BiLevel { get; set; }
  
  
  /// <summary>
  ///   Embossed Color
  /// </summary>
  [SchemaAttr("embosscolor")]
  public String? EmbossColor { get; set; }
  
  
  /// <summary>
  ///   Black Recoloring Color
  /// </summary>
  [SchemaAttr("recolortarget")]
  public String? RecolorTarget { get; set; }
  
  
  /// <summary>
  ///   Image Data Title
  /// </summary>
  [SchemaAttr("o:title")]
  public String? Title { get; set; }
  
  
  /// <summary>
  ///   Detect Mouse Click
  /// </summary>
  [SchemaAttr("o:detectmouseclick")]
  public Boolean? DetectMouseClick { get; set; }
  
  
  /// <summary>
  ///   Relationship to Part
  /// </summary>
  [SchemaAttr("o:relid")]
  public String? RelId { get; set; }
  
  
  /// <summary>
  ///   Explicit Relationship to Image Data
  /// </summary>
  [SchemaAttr("r:id")]
  public String? RelationshipId { get; set; }
  
  
  /// <summary>
  ///   Explicit Relationship to Alternate Image Data
  /// </summary>
  [SchemaAttr("r:pict")]
  public String? Picture { get; set; }
  
  
  /// <summary>
  ///   Explicit Relationship to Hyperlink Target
  /// </summary>
  [SchemaAttr("r:href")]
  public String? RelHref { get; set; }
  
}
