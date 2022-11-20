namespace DocumentModel.Drawing;

/// <summary>
/// Space Before.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.ISpacingPercent))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ISpacingPoints))]
public class SpaceBefore: ISpaceBefore
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
