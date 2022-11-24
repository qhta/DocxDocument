namespace DocumentModel.Drawing;

/// <summary>
/// Defines the TextSpacingType Class.
/// </summary>
public interface ITextSpacingType // : DocumentModel.ITypedOpenXmlCompositeElement
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
