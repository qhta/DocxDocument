namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents line numbering settings for a section in a Wordprocessing document.
/// This interface provides properties for line number increments, starting value, distance between text and line numbers, and restart settings, enabling advanced configuration of line numbering behavior and appearance.
/// </summary>
public interface LineNumberType : ISectionPropertiesContent
{
  
  /// <summary>
  /// Line number increments to display, specifying the interval between displayed line numbers.
  /// </summary>
  public Int16? CountBy { get; set; }
  
  /// <summary>
  /// Line numbering starting value, specifying the initial line number for the section.
  /// </summary>
  public Int16? Start { get; set; }
  
  /// <summary>
  /// Distance between text and line numbering, specifying the spacing for line number placement.
  /// </summary>
  public string? Distance { get; set; }
  
  /// <summary>
  /// Line numbering restart setting, specifying when line numbering should restart (e.g., each page or section).
  /// </summary>
  public LineNumberRestartKind? Restart { get; set; }
}