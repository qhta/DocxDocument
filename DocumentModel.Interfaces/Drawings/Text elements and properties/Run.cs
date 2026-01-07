namespace DocumentModel.Drawings;

/// <summary>
///   Represents a text run, including character properties and the text string.
/// </summary>
public interface Run
{
  /// <summary>
  ///   Character properties applied to the text run.
  /// </summary>
  public RunProperties? RunProperties { get; set; }

  /// <summary>
  ///   Text string content of the run.
  /// </summary>
  public string? Text { get; set; }
}