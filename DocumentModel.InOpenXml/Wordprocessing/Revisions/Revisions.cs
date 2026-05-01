namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the collection of revision elements in a WordprocessingML document.
/// This class is used to organize and manage tracked changes, such as insertions, deletions, moves, and conflict revisions, enabling advanced revision tracking and review capabilities for collaborative document editing.
/// </summary>
[XmlRoot("Revisions", Namespace = "DocumentModel.Wordprocessing")]
public class Revision : ModelElement //<DXW.Revisions>
{
  public HexInt? Id { get; set; }
}