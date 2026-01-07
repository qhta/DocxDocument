namespace DocumentModel.Drawings;

/// <summary>
///   This element provides an override for the color mapping in a document. When defined, this color mapping is used in place of the already defined color mapping, or master color mapping.
///   This color mapping is defined in the same manner as the other mappings within this document.
/// </summary>
public interface OverrideColorMapping : ExtendableElement
{
  /// <summary>
  ///   Specifies the color to use for the background.
  /// </summary>
  public SchemeColorKind? Background1 { get; set; }

  /// <summary>
  ///   Specifies the color to use for the text.
  /// </summary>
  public SchemeColorKind? Text1 { get; set; }

  /// <summary>
  ///   Specifies the color to use for the background (secondary).
  /// </summary>
  public SchemeColorKind? Background2 { get; set; }

  /// <summary>
  ///   Specifies the color to use for the text (secondary).
  /// </summary>
  public SchemeColorKind? Text2 { get; set; }

  /// <summary>
  ///   Specifies the color to use for the accent 1.
  /// </summary>
  public SchemeColorKind? Accent1 { get; set; }

  /// <summary>
  ///   Specifies the color to use for the accent 2.
  /// </summary>
  public SchemeColorKind? Accent2 { get; set; }

  /// <summary>
  ///   Specifies the color to use for the accent 3.
  /// </summary>
  public SchemeColorKind? Accent3 { get; set; }

  /// <summary>
  ///   Specifies the color to use for the accent 4.
  /// </summary>
  public SchemeColorKind? Accent4 { get; set; }

  /// <summary>
  ///   Specifies the color to use for the accent 5.
  /// </summary>
  public SchemeColorKind? Accent5 { get; set; }

  /// <summary>
  ///   Specifies the color to use for the accent 6.
  /// </summary>
  public SchemeColorKind? Accent6 { get; set; }

  /// <summary>
  ///   Specifies the color to use for hyperlinks.
  /// </summary>
  public SchemeColorKind? Hyperlink { get; set; }

  /// <summary>
  ///   Specifies the color to use for followed hyperlinks.
  /// </summary>
  public SchemeColorKind? FollowedHyperlink { get; set; }
}