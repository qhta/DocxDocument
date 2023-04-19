namespace DocumentModel.Vml;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the Shadow Class.
/// </summary>
public class Shadow: ModelElement
{
  /// <summary>
  ///   Unique Identifier
  /// </summary>
  public string? Id { get; set; }

  /// <summary>
  ///   Shadow Toggle
  /// </summary>
  public bool? On { get; set; }

  /// <summary>
  ///   Shadow Type
  /// </summary>
  public ShadowKind? Type { get; set; }

  /// <summary>
  ///   Shadow Transparency
  /// </summary>
  public bool? Obscured { get; set; }

  /// <summary>
  ///   Shadow Primary Color
  /// </summary>
  public string? Color { get; set; }

  /// <summary>
  ///   Shadow Opacity
  /// </summary>
  public string? Opacity { get; set; }

  /// <summary>
  ///   Shadow Primary Offset
  /// </summary>
  public string? Offset { get; set; }

  /// <summary>
  ///   Shadow Secondary Color
  /// </summary>
  public string? Color2 { get; set; }

  /// <summary>
  ///   Shadow Secondary Offset
  /// </summary>
  public string? Offset2 { get; set; }

  /// <summary>
  ///   Shadow Origin
  /// </summary>
  public string? Origin { get; set; }

  /// <summary>
  ///   Shadow Perspective Matrix
  /// </summary>
  public string? Matrix { get; set; }
}