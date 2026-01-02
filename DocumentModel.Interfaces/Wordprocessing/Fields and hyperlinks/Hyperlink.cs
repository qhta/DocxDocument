using DocumentModel.BaseTypes;
namespace DocumentModel.Wordprocessing;
/// <summary>
///   This element specifies the presence of a hyperlink at the current location in the document.
/// </summary>
public class Hyperlink: ElementCollection<IModelElement>, 
  IParagraphContent, 
  ISdtRunContent, 
  IBidirectionalContent, 
  DMM.IMathArgumentContent
{
  /// <summary>
  ///   Hyperlink Target Frame
  /// </summary>
  public string? TargetFrame { get; set; }
  /// <summary>
  ///   Associated String
  /// </summary>
  public string? Tooltip { get; set; }
  /// <summary>
  ///   Location in Target Document
  /// </summary>
  public string? DocLocation { get; set; }
  /// <summary>
  ///   Add To Viewed Hyperlinks
  /// </summary>
  public bool? History { get; set; }
  /// <summary>
  ///   Hyperlink Anchor
  /// </summary>
  public string? Anchor { get; set; }
  /// <summary>
  ///   Hyperlink Target
  /// </summary>
  public string? Id { get; set; }
}