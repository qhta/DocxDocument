namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Build Chart.
/// </summary>
public class BuildChart: ModelElement
{
  /// <summary>
  ///   Build
  /// </summary>
  public string? Build { get; set; }

  /// <summary>
  ///   Animate Background
  /// </summary>
  public bool? AnimateBackground { get; set; }
}