namespace DocumentModel.Math;

/// <summary>
/// Group-Character Properties.
/// </summary>
public interface IGroupCharProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Group Character (Grouping Character).
  /// </summary>
  public String? AccentChar { get ; set; }
  
  /// <summary>
  /// Position (Group Character).
  /// </summary>
  public VerticalJustificationKind? Position { get ; set; }
  
  /// <summary>
  /// Vertical Justification.
  /// </summary>
  public VerticalJustificationKind? VerticalJustification { get ; set; }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public IControlProperties? ControlProperties { get ; set; }
  
}
