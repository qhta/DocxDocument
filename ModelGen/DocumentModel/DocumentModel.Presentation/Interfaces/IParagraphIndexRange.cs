namespace DocumentModel.Presentation;

/// <summary>
/// Paragraph Text Range.
/// </summary>
public interface IParagraphIndexRange // : DocumentFormat.OpenXml.Presentation.IndexRangeType
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
