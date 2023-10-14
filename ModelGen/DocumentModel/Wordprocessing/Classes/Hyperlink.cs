namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the Hyperlink Class.
/// </summary>
public partial class Hyperlink
{
  
  /// <summary>
  ///   Hyperlink Target Frame
  /// </summary>
  public String? TargetFrame { get; set; }
  
  
  /// <summary>
  ///   Associated String
  /// </summary>
  public String? Tooltip { get; set; }
  
  
  /// <summary>
  ///   Location in Target Document
  /// </summary>
  public String? DocLocation { get; set; }
  
  
  /// <summary>
  ///   Add To Viewed Hyperlinks
  /// </summary>
  public Boolean? History { get; set; }
  
  
  /// <summary>
  ///   Hyperlink Anchor
  /// </summary>
  public String? Anchor { get; set; }
  
  
  /// <summary>
  ///   Hyperlink Target
  /// </summary>
  public String? Id { get; set; }
  
  public DM.ElementCollection<IModelElement>? Items { get; set; }
  
}
