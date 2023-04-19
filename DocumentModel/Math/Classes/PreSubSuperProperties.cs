namespace DocumentModel.Math;

/// <summary>
///   This element specifies the Pre-Sub-Superscript object, 
///   which consists of a base e and a subscript and superscript placed to the left of the base, as in {_1^2}A. 
/// </summary>
public class PreSubSuperProperties: ModelElement
{
  /// <summary>
  ///   Specifies formatting of pre-sub-superscript object argument.
  /// </summary>
  public ControlProperties? ControlProperties { get; set; }
}