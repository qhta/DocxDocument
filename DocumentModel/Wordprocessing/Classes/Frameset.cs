namespace DocumentModel.Wordprocessing;

/// <summary>
///   Nested Frameset Definition.
/// </summary>
public record Frameset
{
  /// <summary>
  ///   Nested Frameset Size.
  /// </summary>
  public String? FrameSize { get; set; }

  /// <summary>
  ///   Frameset Splitter Properties.
  /// </summary>
  public FramesetSplitbar? FramesetSplitbar { get; set; }

  /// <summary>
  ///   Frameset Layout.
  /// </summary>
  public FrameLayoutKind? FrameLayout { get; set; }

  public Frameset? ChildFrameset { get; set; }

  public Frame? Frame { get; set; }
}