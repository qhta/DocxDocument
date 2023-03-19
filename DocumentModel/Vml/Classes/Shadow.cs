namespace DocumentModel.Vml;

/// <summary>
///   Defines the Shadow Class.
/// </summary>
public class Shadow: ModelElement
{
  /// <summary>
  ///   Unique Identifier
  /// </summary>
  public String? Id { get; set; }

  /// <summary>
  ///   Shadow Toggle
  /// </summary>
  public Boolean? On { get; set; }

  /// <summary>
  ///   Shadow Type
  /// </summary>
  public ShadowKind? Type { get; set; }

  /// <summary>
  ///   Shadow Transparency
  /// </summary>
  public Boolean? Obscured { get; set; }

  /// <summary>
  ///   Shadow Primary Color
  /// </summary>
  public String? Color { get; set; }

  /// <summary>
  ///   Shadow Opacity
  /// </summary>
  public String? Opacity { get; set; }

  /// <summary>
  ///   Shadow Primary Offset
  /// </summary>
  public String? Offset { get; set; }

  /// <summary>
  ///   Shadow Secondary Color
  /// </summary>
  public String? Color2 { get; set; }

  /// <summary>
  ///   Shadow Secondary Offset
  /// </summary>
  public String? Offset2 { get; set; }

  /// <summary>
  ///   Shadow Origin
  /// </summary>
  public String? Origin { get; set; }

  /// <summary>
  ///   Shadow Perspective Matrix
  /// </summary>
  public String? Matrix { get; set; }
}