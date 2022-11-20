namespace DocumentModel.Bibliography;

/// <summary>
/// Contributors List.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Bibliography.IAuthor))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.IPerformer))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.IArtist))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.IBookAuthor))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.ICompiler))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.IComposer))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.IConductor))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.ICounsel))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.IDirector))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.IEditor))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.IInterviewee))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.IInterviewer))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.IInventor))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.IProducerName))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.ITranslator))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.IWriter))]
public class AuthorList: IAuthorList
{
  /// <summary>
  /// Artist.
  /// </summary>
  public IArtist? Artist
  {
    get;
    set;
  }
  
  /// <summary>
  /// Author.
  /// </summary>
  public DocumentModel.Bibliography.IAuthor? Author
  {
    get;
    set;
  }
  
  /// <summary>
  /// Book Author.
  /// </summary>
  public IBookAuthor? BookAuthor
  {
    get;
    set;
  }
  
  /// <summary>
  /// Compiler.
  /// </summary>
  public ICompiler? Compiler
  {
    get;
    set;
  }
  
  /// <summary>
  /// Composer.
  /// </summary>
  public IComposer? Composer
  {
    get;
    set;
  }
  
  /// <summary>
  /// Conductor.
  /// </summary>
  public IConductor? Conductor
  {
    get;
    set;
  }
  
  /// <summary>
  /// Counsel.
  /// </summary>
  public ICounsel? Counsel
  {
    get;
    set;
  }
  
  /// <summary>
  /// Director.
  /// </summary>
  public IDirector? Director
  {
    get;
    set;
  }
  
  /// <summary>
  /// Editor.
  /// </summary>
  public IEditor? Editor
  {
    get;
    set;
  }
  
  /// <summary>
  /// Interviewee.
  /// </summary>
  public IInterviewee? Interviewee
  {
    get;
    set;
  }
  
  /// <summary>
  /// Interviewer.
  /// </summary>
  public IInterviewer? Interviewer
  {
    get;
    set;
  }
  
  /// <summary>
  /// Inventor.
  /// </summary>
  public IInventor? Inventor
  {
    get;
    set;
  }
  
  /// <summary>
  /// Performer.
  /// </summary>
  public IPerformer? Performer
  {
    get;
    set;
  }
  
  /// <summary>
  /// Producer Name.
  /// </summary>
  public IProducerName? ProducerName
  {
    get;
    set;
  }
  
  /// <summary>
  /// Translator.
  /// </summary>
  public ITranslator? Translator
  {
    get;
    set;
  }
  
  /// <summary>
  /// Writer.
  /// </summary>
  public IWriter? Writer
  {
    get;
    set;
  }
  
}
