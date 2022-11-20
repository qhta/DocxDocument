namespace DocumentModel.Presentation;

/// <summary>
/// Notes Master.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.IColorMap))]
[ChildElementInfo(typeof(DocumentModel.Presentation.INotesStyle))]
[ChildElementInfo(typeof(DocumentModel.Presentation.ICommonSlideData))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IHeaderFooter))]
[ChildElementInfo(typeof(DocumentModel.Presentation.INotesMasterExtensionList))]
public class NotesMaster: INotesMaster
{
  /// <summary>
  /// CommonSlideData.
  /// </summary>
  public ICommonSlideData? CommonSlideData
  {
    get;
    set;
  }
  
  /// <summary>
  /// Color Scheme Map.
  /// </summary>
  public DocumentModel.Presentation.IColorMap? ColorMap
  {
    get;
    set;
  }
  
  /// <summary>
  /// HeaderFooter.
  /// </summary>
  public DocumentModel.Presentation.IHeaderFooter? HeaderFooter
  {
    get;
    set;
  }
  
  /// <summary>
  /// NotesStyle.
  /// </summary>
  public INotesStyle? NotesStyle
  {
    get;
    set;
  }
  
  /// <summary>
  /// NotesMasterExtensionList.
  /// </summary>
  public INotesMasterExtensionList? NotesMasterExtensionList
  {
    get;
    set;
  }
  
}
