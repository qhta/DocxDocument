namespace DocumentModel.Drawing;

/// <summary>
/// Space After.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.ISpacingPercent))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ISpacingPoints))]
public interface ISpaceAfter // : DocumentFormat.OpenXml.Drawing.TextSpacingType
{
  /// <summary>
  /// Spacing Percent.
  /// </summary>
  public ISpacingPercent? SpacingPercent { get ; set; }
  
  /// <summary>
  /// Spacing Points.
  /// </summary>
  public ISpacingPoints? SpacingPoints { get ; set; }
  
}
