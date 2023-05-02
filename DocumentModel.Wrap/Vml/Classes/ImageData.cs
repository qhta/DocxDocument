namespace DocumentModel.Vml;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the ImageData Class.
/// </summary>
public class ImageData: ModelElement
{
  /// <summary>
  ///   Unique Identifier
  /// </summary>
  public string? Id { get; set; }

  /// <summary>
  ///   Image Transparency Color
  /// </summary>
  public string? ChromAKey { get; set; }

  /// <summary>
  ///   Image Left Crop
  /// </summary>
  public string? CropLeft { get; set; }

  /// <summary>
  ///   Image Top Crop
  /// </summary>
  public string? CropTop { get; set; }

  /// <summary>
  ///   Image Right Crop
  /// </summary>
  public string? CropRight { get; set; }

  /// <summary>
  ///   Image Bottom Crop
  /// </summary>
  public string? CropBottom { get; set; }

  /// <summary>
  ///   Image Intensity
  /// </summary>
  public string? Gain { get; set; }

  /// <summary>
  ///   Image Brightness
  /// </summary>
  public string? BlackLevel { get; set; }

  /// <summary>
  ///   Image Gamma Correction
  /// </summary>
  public string? Gamma { get; set; }

  /// <summary>
  ///   Image Grayscale Toggle
  /// </summary>
  public Boolean Grayscale { get; set; }

  /// <summary>
  ///   Image Bilevel Toggle
  /// </summary>
  public bool? BiLevel { get; set; }

  /// <summary>
  ///   Embossed Color
  /// </summary>
  public string? EmbossColor { get; set; }

  /// <summary>
  ///   Black Recoloring Color
  /// </summary>
  public string? RecolorTarget { get; set; }

  /// <summary>
  ///   Image Data Title
  /// </summary>
  public string? Title { get; set; }

  /// <summary>
  ///   Detect Mouse Click
  /// </summary>
  public bool? DetectMouseClick { get; set; }

  /// <summary>
  ///   Relationship to Part
  /// </summary>
  public string? RelId { get; set; }

  /// <summary>
  ///   Explicit Relationship to Image Data
  /// </summary>
  public string? RelationshipId { get; set; }

  /// <summary>
  ///   Explicit Relationship to Alternate Image Data
  /// </summary>
  public string? Picture { get; set; }

  /// <summary>
  ///   Explicit Relationship to Hyperlink Target
  /// </summary>
  public string? RelHref { get; set; }
}