namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the PaperSource Class.
/// </summary>
public interface PaperSource // : System.Boolean
{
  /// <summary>
  /// First Page Printer Tray Code
  /// </summary>
  public UInt16? First { get ; set; }
  
  /// <summary>
  /// Non-First Page Printer Tray Code
  /// </summary>
  public UInt16? Other { get ; set; }
  
}
