namespace DocumentModel.Drawings;

/// <summary>
///   Defines the ImageLayer Class.
/// </summary>
public class ImageLayer: ModelElement
{
  /// <summary>
  ///   embed, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Embed { get; set; }
  public Collection<ImageEffect>? ImageEffects { get; set; }
}