namespace DocumentModel.Vml;

/// <summary>
/// Defines the ImageData Class.
/// </summary>
public partial interface ImageData
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  public String? Id { get; set; }
  
  /// <summary>
  /// Image Transparency Color
  /// </summary>
  public String? ChromAKey { get; set; }
  
  /// <summary>
  /// Image Left Crop
  /// </summary>
  public String? CropLeft { get; set; }
  
  /// <summary>
  /// Image Top Crop
  /// </summary>
  public String? CropTop { get; set; }
  
  /// <summary>
  /// Image Right Crop
  /// </summary>
  public String? CropRight { get; set; }
  
  /// <summary>
  /// Image Bottom Crop
  /// </summary>
  public String? CropBottom { get; set; }
  
  /// <summary>
  /// Image Intensity
  /// </summary>
  public String? Gain { get; set; }
  
  /// <summary>
  /// Image Brightness
  /// </summary>
  public String? BlackLevel { get; set; }
  
  /// <summary>
  /// Image Gamma Correction
  /// </summary>
  public String? Gamma { get; set; }
  
  /// <summary>
  /// Image Grayscale Toggle
  /// </summary>
  public Boolean? Grayscale { get; set; }
  
  /// <summary>
  /// Image Bilevel Toggle
  /// </summary>
  public Boolean? BiLevel { get; set; }
  
  /// <summary>
  /// Embossed Color
  /// </summary>
  public String? EmbossColor { get; set; }
  
  /// <summary>
  /// Black Recoloring Color
  /// </summary>
  public String? RecolorTarget { get; set; }
  
  /// <summary>
  /// Image Data Title
  /// </summary>
  public String? Title { get; set; }
  
  /// <summary>
  /// Detect Mouse Click
  /// </summary>
  public Boolean? DetectMouseClick { get; set; }
  
  /// <summary>
  /// Relationship to Part
  /// </summary>
  public String? RelId { get; set; }
  
  /// <summary>
  /// Explicit Relationship to Image Data
  /// </summary>
  public String? RelationshipId { get; set; }
  
  /// <summary>
  /// Explicit Relationship to Alternate Image Data
  /// </summary>
  public String? Picture { get; set; }
  
  /// <summary>
  /// Explicit Relationship to Hyperlink Target
  /// </summary>
  public String? RelHref { get; set; }
  
}
