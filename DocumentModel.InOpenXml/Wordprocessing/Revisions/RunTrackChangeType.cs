namespace DocumentModel.Wordprocessing;
/// <summary>
///   Common base class for <see cref = "InsertedRun"/>, <see cref = "DeletedRun"/>, <see cref = "MoveFromRun"/>, and <see cref = "MoveToRun"/>.
///   Provides run-level revision tracking, including author, date, annotation identifier, and run content collection.
///   Implements <see cref = "IElementCollection{IParagraphContent}"/> and <see cref = "ICommonContent"/>.
/// </summary>
public partial class RunTrackChangeType : TrackChangeType<DXW.RunTrackChangeType>
{
}
