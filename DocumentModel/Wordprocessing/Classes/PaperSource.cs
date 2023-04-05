namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the PaperSource Class.
/// </summary>
public class PaperSource: ModelElement, ISectionPropertiesContent
{
  /// <summary>
  ///   First Page Printer Tray Code
  /// </summary>
  public UInt16? First { get; set; }

  /// <summary>
  ///   Non-First Page Printer Tray Code
  /// </summary>
  public UInt16? Other { get; set; }
}