namespace DocumentModel.Bibliography;

public interface IAuthorList // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public IArtist? Artist { get ; set; }

  public DocumentModel.Bibliography.IAuthor? Author { get ; set; }

  public IBookAuthor? BookAuthor { get ; set; }

  public ICompiler? Compiler { get ; set; }

  public IComposer? Composer { get ; set; }

  public IConductor? Conductor { get ; set; }

  public ICounsel? Counsel { get ; set; }

  public IDirector? Director { get ; set; }

  public IEditor? Editor { get ; set; }

  public IInterviewee? Interviewee { get ; set; }

  public IInterviewer? Interviewer { get ; set; }

  public IInventor? Inventor { get ; set; }

  public IPerformer? Performer { get ; set; }

  public IProducerName? ProducerName { get ; set; }

  public ITranslator? Translator { get ; set; }

  public IWriter? Writer { get ; set; }

}
