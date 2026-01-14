namespace DocumentModel.Math;
/// <summary>
///   This element specifies properties such as ctrlPr that can be stored on the Subscript object.
/// </summary>
public class SubscriptProperties: ModelElement
{
  /// <summary>
  ///   Specifies formatting of Subscript object argument.
  /// </summary>
  public ControlProperties? ControlProperties { get; set; }
}