namespace DocumentModel.Presentation;

/// <summary>
/// Notes Master.
/// </summary>
public interface INotesMaster // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// CommonSlideData.
  /// </summary>
  public DocumentModel.Presentation.ICommonSlideData? CommonSlideData { get ; set; }
  
  /// <summary>
  /// Color Scheme Map.
  /// </summary>
  public DocumentModel.Presentation.IColorMap? ColorMap { get ; set; }
  
  /// <summary>
  /// HeaderFooter.
  /// </summary>
  public DocumentModel.Presentation.IHeaderFooter? HeaderFooter { get ; set; }
  
  /// <summary>
  /// NotesStyle.
  /// </summary>
  public DocumentModel.Presentation.INotesStyle? NotesStyle { get ; set; }
  
  /// <summary>
  /// NotesMasterExtensionList.
  /// </summary>
  public DocumentModel.Presentation.INotesMasterExtensionList? NotesMasterExtensionList { get ; set; }
  
}
