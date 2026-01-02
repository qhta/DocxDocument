namespace DocumentModel.Math;
/// <summary>
///   This element specifies properties of the Sub-Superscript object, including the alignment of scripts.
/// </summary>
public class SubSuperscriptProperties: ModelElement
{
  /// <summary>
  ///   This element specifies the alignment of scripts in the subscript/superscript function. 
  ///   When 1 or true, subscripts and superscripts are aligned to each other. 
  ///   When 0 or false, they are kerned to the shape of the base. 
  ///   If this element is omitted, scripts are not aligned. 
  ///   In other words, when the element is absent, the default is for the sub-superscript object 
  ///   to not align the superscript and subscript with each other
  /// </summary>
  public bool? AlignScripts { get; set; }
  /// <summary>
  ///   Specifies formatting of SubSuperscript object argument.
  /// </summary>
  public ControlProperties? ControlProperties { get; set; }
}