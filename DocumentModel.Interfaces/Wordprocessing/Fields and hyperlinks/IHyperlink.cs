
namespace DocumentModel.Wordprocessing;
/// <summary>
///   This element specifies the presence of a hyperlink at the current location in the document.
/// </summary>
public interface IHyperlink: IElementCollection<IModelElement>, 
  IParagraphContent, 
  ISdtRunContent, 
  IBidirectionalContent, 
  DMM.IMathArgumentContent
{
  /// <summary>
  ///   IHyperlink Target Frame
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
  ///   IHyperlink Anchor
  /// </summary>
  public string? Anchor { get; set; }
  /// <summary>
  ///   IHyperlink Target
  /// </summary>
  public string? Id { get; set; }
}