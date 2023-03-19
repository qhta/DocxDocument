namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the CustomXmlConflictDeletionRangeStart Class.
/// </summary>
public class CustomXmlConflictDeletionRangeStart: TrackChangeType2
{
  public override int GetHashCode()
  {
    Debug.Indent();
    var hashCode = base.GetHashCode();
    Debug.WriteLine($"{this}.HashCode={hashCode}");
    Debug.Unindent();
    return hashCode;
  }
}