namespace DocumentModel.Math;
/// <summary>
///   This element specifies properties such as ctrlPr that can be stored on the function apply object func.
/// </summary>
public partial class FunctionProperties : ModelElement<DXM.FunctionProperties>
{
  /// <summary>
  ///   ControlProperties.
  /// </summary>
  public ControlProperties? ControlProperties { get; set; }
}