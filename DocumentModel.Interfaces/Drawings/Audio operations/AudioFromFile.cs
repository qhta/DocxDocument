namespace DocumentModel.Drawings;

/// <summary>
/// Represents audio sourced from a file, including a linked relationship ID and optional extension data.
/// </summary>
public interface AudioFromFile
{
  /// <summary>
  /// Gets or sets the linked relationship ID that references the audio file.
  /// </summary>
  public string? Link { get; set; }

  /// <summary>
  /// Gets or sets the extension list containing additional metadata or custom extensions.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}