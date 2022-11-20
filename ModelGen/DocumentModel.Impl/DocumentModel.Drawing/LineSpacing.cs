namespace DocumentModel.Drawing;

/// <summary>
/// Line Spacing.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.ISpacingPercent))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ISpacingPoints))]
public class LineSpacing: ILineSpacing
{
  /// <summary>
  /// Spacing Percent.
  /// </summary>
  public ISpacingPercent? SpacingPercent
  {
    get;
    set;
  }
  
  /// <summary>
  /// Spacing Points.
  /// </summary>
  public ISpacingPoints? SpacingPoints
  {
    get;
    set;
  }
  
}
