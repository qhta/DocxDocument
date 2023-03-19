namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the CustomXmlConflictDeletionRangeEnd Class.
/// </summary>
public class CustomXmlConflictDeletionRangeEnd: MarkupType2
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