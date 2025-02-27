namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Page Margins.
/// </summary>
public class PageMargins: ModelElement
{
  /// <summary>
  ///   Left
  /// </summary>
  public Double? Left { get; set; }

  /// <summary>
  ///   Right
  /// </summary>
  public Double? Right { get; set; }

  /// <summary>
  ///   Top
  /// </summary>
  public Double? Top { get; set; }

  /// <summary>
  ///   Bottom
  /// </summary>
  public Double? Bottom { get; set; }

  /// <summary>
  ///   Header
  /// </summary>
  public Double? Header { get; set; }

  /// <summary>
  ///   Footer
  /// </summary>
  public Double? Footer { get; set; }
}