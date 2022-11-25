namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the PaperSource Class.
/// </summary>
public interface IPaperSource // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// First Page Printer Tray Code
  /// </summary>
  public System.UInt16? First { get ; set; }
  
  /// <summary>
  /// Non-First Page Printer Tray Code
  /// </summary>
  public System.UInt16? Other { get ; set; }
  
}
