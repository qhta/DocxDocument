namespace DocumentModel.Presentation;

/// <summary>
/// Notes Master.
/// </summary>
public interface INotesMaster // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// CommonSlideData.
  /// </summary>
  public ICommonSlideData? CommonSlideData { get ; set; }
  
  /// <summary>
  /// Color Scheme Map.
  /// </summary>
  public IColorMap? ColorMap { get ; set; }
  
  /// <summary>
  /// HeaderFooter.
  /// </summary>
  public IHeaderFooter? HeaderFooter { get ; set; }
  
  /// <summary>
  /// NotesStyle.
  /// </summary>
  public INotesStyle? NotesStyle { get ; set; }
  
  /// <summary>
  /// NotesMasterExtensionList.
  /// </summary>
  public INotesMasterExtensionList? NotesMasterExtensionList { get ; set; }
  
}
