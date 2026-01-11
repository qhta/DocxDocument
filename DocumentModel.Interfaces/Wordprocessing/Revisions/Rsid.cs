namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a revision identifier in a WordprocessingML document.
/// This interface provides a hexadecimal identifier for a tracked change, enabling unique identification and management of document revisions.
/// </summary>
public interface Rsid
{

  /// <summary>
  /// Hexadecimal identifier of the revision, used to uniquely reference a tracked change.
  /// </summary>
  public HexInt Id { get; set; }
}