namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the Item Class.
/// </summary>
public class Item: ModelElement
{
  /// <summary>
  ///   id, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Id { get; set; }

  /// <summary>
  ///   label, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Label { get; set; }

  /// <summary>
  ///   image, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Image { get; set; }

  /// <summary>
  ///   imageMso, this property is only available in Office 2010 and later.
  /// </summary>
  public string? ImageMso { get; set; }

  /// <summary>
  ///   screentip, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Screentip { get; set; }

  /// <summary>
  ///   supertip, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Supertip { get; set; }
}