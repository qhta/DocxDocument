namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the HyperlinkExtension Class.
/// </summary>
public class HyperlinkExtension: ModelElement
{
  /// <summary>
  ///   URI
  /// </summary>
  public String? Uri { get; set; }

  public HyperlinkColorEnum? HyperlinkColor { get; set; }
}