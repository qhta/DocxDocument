namespace DocumentModel.Wordprocessing;

/// <summary>
///   Listing of All Revision Save ID Values.
/// </summary>
public class Rsids
{
  /// <summary>
  ///   Original Document Revision Save ID.
  /// </summary>
  public NumId? RsidRoot { get; set; }

  public Collection<NumId>? Items { get; set; }
}