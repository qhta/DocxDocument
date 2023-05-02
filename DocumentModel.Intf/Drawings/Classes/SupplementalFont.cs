namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Font.
/// </summary>
public class SupplementalFont: ModelElement
{
  /// <summary>
  ///   Script
  /// </summary>
  public string? Script { get; set; }

  /// <summary>
  ///   Typeface
  /// </summary>
  public string? Typeface { get; set; }
}