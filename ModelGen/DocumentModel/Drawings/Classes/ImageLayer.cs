namespace DocumentModel.Drawings;


/// <summary>
///   Defines the ImageLayer Class.
/// </summary>
public partial class ImageLayer
{
  
  /// <summary>
  ///   embed, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Embed { get; set; }
  
  public ElementCollection<ImageEffect>? Items { get; set; }
  
}
