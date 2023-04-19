namespace DocumentModel.Math;

/// <summary>
///   This element specifies the properties of the array object, including the vertical justification of the object and layout inside the object. 
/// </summary>
public class EquationArrayProperties: ModelElement
{
  /// <summary>
  ///   Equation Array Base Justification.
  /// </summary>
  public VerticalAlignmentKind? BaseJustification { get; set; }

  /// <summary>
  ///   Maximum Distribution.
  /// </summary>
  public bool? MaxDistribution { get; set; }

  /// <summary>
  ///   Object Distribution.
  /// </summary>
  public bool? ObjectDistribution { get; set; }

  /// <summary>
  ///   Row Spacing (Equation Array). The meaning of the value is unspecified.
  /// </summary>
  public RowSpacing? RowSpacing { get; set; }

  /// <summary>
  ///   Specifies formatting of equation array object argument.
  /// </summary>
  public ControlProperties? ControlProperties { get; set; }
}