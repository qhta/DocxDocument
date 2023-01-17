namespace DocumentModel.Wordprocessing;

/// <summary>
///   Listing of All Revision Save ID Values.
/// </summary>
public class Rsids
{
  /// <summary>
  ///   Original Document Revision Save ID.
  /// </summary>
  public UInt32? RsidRoot { get; set; }

  public Collection<UInt32>? Items { get; set; }
}