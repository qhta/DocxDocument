namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a listing of all revision save ID values in a WordprocessingML document.
/// </summary>
public partial class Rsids : ModelElementCollection<Rsid, DXW.Rsids, DXW.Rsid>
{
  /// <summary>
  /// Original document revision save ID, identifying the root revision of the document.
  /// </summary>
  [OpenXmlProperty(nameof(Rsids.RsidRoot))]
  public Rsid? RsidRoot { get; set; }
}