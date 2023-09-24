namespace DocumentModel.Wordprocessing;


/// <summary>
///   Listing of All Revision Save ID Values.
/// </summary>
public partial class Rsids
{
  
  /// <summary>
  ///   Original Document Revision Save ID.
  /// </summary>
  public UInt32? RsidRoot { get; set; }
  
  public ElementCollection<UInt32>? Items { get; set; }
  
}
