namespace DocumentModel.Drawings;

/// <summary>
///   Represents a sharpen or soften effect, allowing adjustment of the amount for image enhancement.
/// </summary>
public class SharpenSoften: ModelElement
{
  /// <summary>
  ///   Amount of sharpening or softening applied.
  /// </summary>
  public Int32? Amount { get; set; }
}