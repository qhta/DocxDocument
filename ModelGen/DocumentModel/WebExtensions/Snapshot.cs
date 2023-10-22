namespace DocumentModel.WebExtensions;


/// <summary>
///   Defines the Snapshot Class.
/// </summary>
public partial class Snapshot
{
  
  /// <summary>
  ///   Embedded Picture Reference
  /// </summary>
  public String? Embed { get; set; }
  
  
  /// <summary>
  ///   Linked Picture Reference
  /// </summary>
  public String? Link { get; set; }
  
  public DocumentModel.Drawings.BlipExtensionList? BlipExtensionList { get; set; }
  
}
