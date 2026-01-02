namespace DocumentModel;

/// <summary>
///   Defines the ImageControl Class.
/// </summary>
public class ImageControl: ModelElement
{
  /// <summary>
  ///   id, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Id { get; set; }
  /// <summary>
  ///   idQ, this property is only available in Office 2010 and later.
  /// </summary>
  public string? QualifiedId { get; set; }
  /// <summary>
  ///   tag, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Tag { get; set; }
  /// <summary>
  ///   enabled, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? Enabled { get; set; }
  /// <summary>
  ///   getEnabled, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetEnabled { get; set; }
  /// <summary>
  ///   visible, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? Visible { get; set; }
  /// <summary>
  ///   getVisible, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetVisible { get; set; }
  /// <summary>
  ///   image, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Image { get; set; }
  /// <summary>
  ///   imageMso, this property is only available in Office 2010 and later.
  /// </summary>
  public string? ImageMso { get; set; }
  /// <summary>
  ///   getImage, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetImage { get; set; }
  /// <summary>
  ///   altText, this property is only available in Office 2010 and later.
  /// </summary>
  public string? AltText { get; set; }
  /// <summary>
  ///   getAltText, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetAltText { get; set; }
}