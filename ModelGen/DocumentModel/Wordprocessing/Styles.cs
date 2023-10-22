namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies all of the style information stored in the WordprocessingML document: style definitions as well as latent style information.
/// </summary>
public partial class Styles
{
  
  /// <summary>
  ///   Document Default Paragraph and Run Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.DocDefaults? DocDefaults { get; set; }
  
  
  /// <summary>
  ///   Latent Style Information.
  /// </summary>
  public DocumentModel.Wordprocessing.LatentStyles? LatentStyles { get; set; }
  
}
