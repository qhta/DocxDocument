namespace DocumentModel.UI;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the Item Class.
/// </summary>
public class Item: ModelElement
{
  /// <summary>
  ///   id
  /// </summary>
  public String? Id { get; set; }

  /// <summary>
  ///   label
  /// </summary>
  public String? Label { get; set; }

  /// <summary>
  ///   image
  /// </summary>
  public String? Image { get; set; }

  /// <summary>
  ///   imageMso
  /// </summary>
  public String? ImageMso { get; set; }

  /// <summary>
  ///   screentip
  /// </summary>
  public String? Screentip { get; set; }

  /// <summary>
  ///   supertip
  /// </summary>
  public String? Supertip { get; set; }
}