namespace DocumentModel.Math;

/// <summary>
/// Group-Character Properties.
/// </summary>
public interface IGroupCharProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Group Character (Grouping Character).
  /// </summary>
  public IAccentChar? AccentChar { get ; set; }
  
  /// <summary>
  /// Position (Group Character).
  /// </summary>
  public IPosition? Position { get ; set; }
  
  /// <summary>
  /// Vertical Justification.
  /// </summary>
  public IVerticalJustification? VerticalJustification { get ; set; }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public IControlProperties? ControlProperties { get ; set; }
  
}
