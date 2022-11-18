namespace DocumentModel.Presentation;

/// <summary>
/// Audio.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.ICommonMediaNode))]
public interface IAudio // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Is Narration
  /// </summary>
  public bool? IsNarration { get ; set; }
  
  /// <summary>
  /// Common Media Node Properties.
  /// </summary>
  public ICommonMediaNode? CommonMediaNode { get ; set; }
  
}
