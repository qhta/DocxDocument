namespace DocumentModel.Drawings;

/// <summary>
///   Defines the ImageLayer Class.
/// </summary>
public record ImageLayer
{
  /// <summary>
  ///   embed, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Embed { get; set; }

  public Collection<ImageEffect>? ImageEffects { get; set; }
}