namespace DocumentModel.Math;
/// <summary>
///   This element specifies properties such as ctrlPr that can be stored on the Superscript object.
/// </summary>
public class SuperscriptProperties: ModelElement
{
  /// <summary>
  ///   Specifies formatting of Superscript object argument.
  /// </summary>
  public ControlProperties? ControlProperties { get; set; }
}