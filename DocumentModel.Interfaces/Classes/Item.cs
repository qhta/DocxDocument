namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the Item Class.
/// </summary>
public interface Item:
{
  /// <summary>
  ///   id
  /// </summary>
  public string? Id { get; set; }

  /// <summary>
  ///   label
  /// </summary>
  public string? Label { get; set; }

  /// <summary>
  ///   image
  /// </summary>
  public string? Image { get; set; }

  /// <summary>
  ///   imageMso
  /// </summary>
  public string? ImageMso { get; set; }

  /// <summary>
  ///   screentip
  /// </summary>
  public string? Screentip { get; set; }

  /// <summary>
  ///   supertip
  /// </summary>
  public string? Supertip { get; set; }
}