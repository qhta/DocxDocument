namespace DocumentModel;

/// <summary>
///   Defines the ImageControl Class.
/// </summary>
public interface ImageControl: IModelElement
{
  /// <summary>
  ///   id
  /// </summary>
  public string? Id { get; set; }
  /// <summary>
  ///   idQ
  /// </summary>
  public string? QualifiedId { get; set; }
  /// <summary>
  ///   tag
  /// </summary>
  public string? Tag { get; set; }
  /// <summary>
  ///   enabled
  /// </summary>
  public bool? Enabled { get; set; }
  /// <summary>
  ///   getEnabled
  /// </summary>
  public string? GetEnabled { get; set; }
  /// <summary>
  ///   visible
  /// </summary>
  public bool? Visible { get; set; }
  /// <summary>
  ///   getVisible
  /// </summary>
  public string? GetVisible { get; set; }
  /// <summary>
  ///   image
  /// </summary>
  public string? Image { get; set; }
  /// <summary>
  ///   imageMso
  /// </summary>
  public string? ImageMso { get; set; }
  /// <summary>
  ///   getImage
  /// </summary>
  public string? GetImage { get; set; }
  /// <summary>
  ///   altText
  /// </summary>
  public string? AltText { get; set; }
  /// <summary>
  ///   getAltText
  /// </summary>
  public string? GetAltText { get; set; }
}