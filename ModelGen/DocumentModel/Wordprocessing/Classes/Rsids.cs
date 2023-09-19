namespace DocumentModel.Wordprocessing;


/// <summary>
///   Listing of All Revision Save ID Values.
/// </summary>
public partial class Rsids
{
  
  /// <summary>
  ///   Original Document Revision Save ID.
  /// </summary>
  [Nullable((Byte)2)]
  public UInt32? RsidRoot { get; set; }
  
  public DocumentModel.ElementCollection<System.UInt32>? Items { get; set; }
  
}
