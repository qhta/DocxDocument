namespace DocumentModel.Math;

/// <summary>
/// Group-Character Properties.
/// </summary>
public interface IGroupCharProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Group Character (Grouping Character).
  /// </summary>
  public System.String? AccentChar { get ; set; }
  
  /// <summary>
  /// Position (Group Character).
  /// </summary>
  public DocumentModel.Math.VerticalJustificationKind? Position { get ; set; }
  
  /// <summary>
  /// Vertical Justification.
  /// </summary>
  public DocumentModel.Math.VerticalJustificationKind? VerticalJustification { get ; set; }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ControlProperties { get ; set; }
  
}
