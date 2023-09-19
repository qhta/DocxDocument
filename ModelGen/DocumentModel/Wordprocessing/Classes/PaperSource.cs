namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the PaperSource Class.
/// </summary>
public partial class PaperSource
{
  
  /// <summary>
  ///   First Page Printer Tray Code
  /// </summary>
  [SchemaAttr("w:first")]
  public UInt16? First { get; set; }
  
  
  /// <summary>
  ///   Non-First Page Printer Tray Code
  /// </summary>
  [SchemaAttr("w:other")]
  public UInt16? Other { get; set; }
  
}
