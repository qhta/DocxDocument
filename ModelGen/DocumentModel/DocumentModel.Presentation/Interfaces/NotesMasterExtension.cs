namespace DocumentModel.Presentation;

/// <summary>
/// Defines the NotesMasterExtension Class.
/// </summary>
public interface NotesMasterExtension // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public SlideGuideList? SlideGuideList { get ; set; }
  
}
