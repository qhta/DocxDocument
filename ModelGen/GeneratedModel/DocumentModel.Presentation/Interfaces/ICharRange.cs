namespace DocumentModel.Presentation;

/// <summary>
/// Character Range.
/// </summary>
public interface ICharRange // : DocumentFormat.OpenXml.Presentation.IndexRangeType
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
