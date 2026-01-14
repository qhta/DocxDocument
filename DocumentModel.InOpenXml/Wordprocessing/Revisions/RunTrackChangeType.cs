namespace DocumentModel.Wordprocessing;

/// <summary>
///   Common base interface for 
///   <see cref="InsertedRun"/>, <see cref="DeletedRun"/>, <see cref="MoveFromRun"/>, and <see cref="MoveToRun"/> classes.
///   This interface extends <see cref="ElementCollection{ParagraphContent}"/> and <see cref="CommonContent"/>, providing properties for author, date, and annotation identifier to enable revision tracking and review of run-level changes in WordprocessingML documents.
/// </summary>
public interface RunTrackChangeType : IdentifiedChange, IElementCollection<IParagraphContent>, CommonContent
{

}