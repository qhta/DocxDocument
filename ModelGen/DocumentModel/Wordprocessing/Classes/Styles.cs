namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies all of the style information stored in the WordprocessingML document: style definitions as well as latent style information.
/// </summary>
public partial class Styles
{
  
  /// <summary>
  ///   Document Default Paragraph and Run Properties.
  /// </summary>
  public DocDefaults? DocDefaults { get; set; }
  
  
  /// <summary>
  ///   Latent Style Information.
  /// </summary>
  public LatentStyles? LatentStyles { get; set; }
  
  public ElementCollection<Style>? Items { get; set; }
  
}
