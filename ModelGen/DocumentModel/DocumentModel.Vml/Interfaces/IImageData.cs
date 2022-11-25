namespace DocumentModel.Vml;

/// <summary>
/// Defines the ImageData Class.
/// </summary>
public interface IImageData // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  public System.String? Id { get ; set; }
  
  /// <summary>
  /// Image Transparency Color
  /// </summary>
  public System.String? ChromAKey { get ; set; }
  
  /// <summary>
  /// Image Left Crop
  /// </summary>
  public System.String? CropLeft { get ; set; }
  
  /// <summary>
  /// Image Top Crop
  /// </summary>
  public System.String? CropTop { get ; set; }
  
  /// <summary>
  /// Image Right Crop
  /// </summary>
  public System.String? CropRight { get ; set; }
  
  /// <summary>
  /// Image Bottom Crop
  /// </summary>
  public System.String? CropBottom { get ; set; }
  
  /// <summary>
  /// Image Intensity
  /// </summary>
  public System.String? Gain { get ; set; }
  
  /// <summary>
  /// Image Brightness
  /// </summary>
  public System.String? BlackLevel { get ; set; }
  
  /// <summary>
  /// Image Gamma Correction
  /// </summary>
  public System.String? Gamma { get ; set; }
  
  /// <summary>
  /// Image Grayscale Toggle
  /// </summary>
  public System.Boolean? Grayscale { get ; set; }
  
  /// <summary>
  /// Image Bilevel Toggle
  /// </summary>
  public System.Boolean? BiLevel { get ; set; }
  
  /// <summary>
  /// Embossed Color
  /// </summary>
  public System.String? EmbossColor { get ; set; }
  
  /// <summary>
  /// Black Recoloring Color
  /// </summary>
  public System.String? RecolorTarget { get ; set; }
  
  /// <summary>
  /// Image Data Title
  /// </summary>
  public System.String? Title { get ; set; }
  
  /// <summary>
  /// Detect Mouse Click
  /// </summary>
  public System.Boolean? DetectMouseClick { get ; set; }
  
  /// <summary>
  /// Relationship to Part
  /// </summary>
  public System.String? RelId { get ; set; }
  
  /// <summary>
  /// Explicit Relationship to Image Data
  /// </summary>
  public System.String? RelationshipId { get ; set; }
  
  /// <summary>
  /// Explicit Relationship to Alternate Image Data
  /// </summary>
  public System.String? Picture { get ; set; }
  
  /// <summary>
  /// Explicit Relationship to Hyperlink Target
  /// </summary>
  public System.String? RelHref { get ; set; }
  
}
