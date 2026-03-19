namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a mathematical equation array object, consisting of one or more equations that can be vertically justified as a unit respect to surrounding text on the line.
/// </summary>
public interface OMathEqArray : InteropObject
{
  /// <summary>
  /// The e.
  /// </summary>
  public OMathArgs E { get; }
  /// <summary>
  /// The max dist.
  /// </summary>
  public bool MaxDist { get; set; }
  /// <summary>
  /// The obj dist.
  /// </summary>
  public bool ObjDist { get; set; }
  /// <summary>
  /// The align.
  /// </summary>
  public WdOMathVertAlignType Align { get; set; }
  /// <summary>
  /// The row spacing rule.
  /// </summary>
  public WdOMathSpacingRule RowSpacingRule { get; set; }
  /// <summary>
  /// The row spacing.
  /// </summary>
  public int RowSpacing { get; set; }

}
