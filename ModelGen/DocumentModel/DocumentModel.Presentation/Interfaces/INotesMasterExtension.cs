namespace DocumentModel.Presentation;

/// <summary>
/// Defines the NotesMasterExtension Class.
/// </summary>
public interface INotesMasterExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Presentation.ISlideGuideList? SlideGuideList { get ; set; }
  
}
