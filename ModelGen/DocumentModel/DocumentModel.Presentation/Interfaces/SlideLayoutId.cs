namespace DocumentModel.Presentation;

/// <summary>
/// Slide Layout Id.
/// </summary>
public interface SlideLayoutId // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// ID Tag
  /// </summary>
  public UInt32? Id { get ; set; }
  
  /// <summary>
  /// ID Tag
  /// </summary>
  public String? RelationshipId { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get ; set; }
  
}
