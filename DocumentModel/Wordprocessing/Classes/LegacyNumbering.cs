namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Legacy Numbering Level Properties.
/// </summary>
public class LegacyNumbering: ModelElement
{
  /// <summary>
  ///   Use Legacy Numbering Properties
  /// </summary>
  public Boolean? Legacy { get; set; }

  /// <summary>
  ///   Legacy Spacing
  /// </summary>
  public String? LegacySpace { get; set; }

  /// <summary>
  ///   Legacy Indent
  /// </summary>
  public String? LegacyIndent { get; set; }
}