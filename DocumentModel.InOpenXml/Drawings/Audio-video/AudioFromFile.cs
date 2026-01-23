namespace DocumentModel.Drawings;

/// <summary>
/// Represents audio sourced from a file, including a linked relationship ID and optional extension data.
/// </summary>
public class AudioFromFile: ModelElement<DXD.AudioFromFile>, IExtendableElement
{
  /// <summary>
  /// Linked relationship ID that references the audio file.
  /// </summary>
  public string? Link { get; set; }

  public ExtensionList? ExtensionList { get; set; }
}