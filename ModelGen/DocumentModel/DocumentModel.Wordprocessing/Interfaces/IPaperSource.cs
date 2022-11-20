namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the PaperSource Class.
/// </summary>
public interface IPaperSource // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// First Page Printer Tray Code
  /// </summary>
  public ushort? First { get ; set; }
  
  /// <summary>
  /// Non-First Page Printer Tray Code
  /// </summary>
  public ushort? Other { get ; set; }
  
}
