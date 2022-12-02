namespace DocumentModel.Drawing;

/// <summary>
/// Defines the TextSpacingType Class.
/// </summary>
public interface ITextSpacingType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Spacing Percent.
  /// </summary>
  public Int32? SpacingPercent { get ; set; }
  
  /// <summary>
  /// Spacing Points.
  /// </summary>
  public Int32? SpacingPoints { get ; set; }
  
}
