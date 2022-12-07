namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Reflection Class.
/// </summary>
public interface Reflection
{
  /// <summary>
  /// algn, this property is only available in Office 2010 and later.
  /// </summary>
  public RectangleAlignmentKind? Alignment { get ; set; }
  
}
