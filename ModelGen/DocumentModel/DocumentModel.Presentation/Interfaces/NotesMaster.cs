namespace DocumentModel.Presentation;

/// <summary>
/// Notes Master.
/// </summary>
public interface NotesMaster // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// CommonSlideData.
  /// </summary>
  public CommonSlideData? CommonSlideData { get ; set; }
  
  /// <summary>
  /// Color Scheme Map.
  /// </summary>
  public ColorMap? ColorMap { get ; set; }
  
  /// <summary>
  /// HeaderFooter.
  /// </summary>
  public HeaderFooter? HeaderFooter { get ; set; }
  
  /// <summary>
  /// NotesStyle.
  /// </summary>
  public NotesStyle? NotesStyle { get ; set; }
  
  /// <summary>
  /// NotesMasterExtensionList.
  /// </summary>
  public NotesMasterExtensionList? NotesMasterExtensionList { get ; set; }
  
}
