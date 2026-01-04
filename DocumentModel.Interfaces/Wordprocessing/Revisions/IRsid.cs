namespace DocumentModel.Wordprocessing;
/// <summary>
///   Revision id.
/// </summary>
public interface IRsid
{
  /// <summary>
  /// Identifier of the revision
  /// </summary>
  public HexInt Id { get; set; }
}