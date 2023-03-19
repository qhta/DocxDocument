namespace DocumentModel;

/// <summary>
///   Defines the Item Class.
/// </summary>
public class Item: ModelElement
{
  /// <summary>
  ///   id, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Id { get; set; }

  /// <summary>
  ///   label, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Label { get; set; }

  /// <summary>
  ///   image, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Image { get; set; }

  /// <summary>
  ///   imageMso, this property is only available in Office 2010 and later.
  /// </summary>
  public String? ImageMso { get; set; }

  /// <summary>
  ///   screentip, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Screentip { get; set; }

  /// <summary>
  ///   supertip, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Supertip { get; set; }
}