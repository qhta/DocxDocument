namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a listing of all revision save ID values in a WordprocessingML document.
/// </summary>
public interface Rsids : IValueCollection<Rsid>
{
  /// <summary>
  /// Original document revision save ID, identifying the root revision of the document.
  /// </summary>
  [XmlAttribute]
  public Rsid? RsidRoot { get; set; }
}