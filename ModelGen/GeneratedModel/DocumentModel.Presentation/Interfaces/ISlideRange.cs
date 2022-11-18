namespace DocumentModel.Presentation;

/// <summary>
/// Slide Range.
/// </summary>
public interface ISlideRange // : DocumentFormat.OpenXml.Presentation.IndexRangeType
{
  /// <summary>
  /// Start
  /// </summary>
  public uint? Start { get ; set; }
  
  /// <summary>
  /// End
  /// </summary>
  public uint? End { get ; set; }
  
}
