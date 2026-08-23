namespace DocumentModel.Math;
/// <summary>
///   This element specifies the name of the function in the Function-Apply object func. 
///   For example, function names are sin and cos.
/// </summary>
[OpenXmlType(typeof(DXM.FunctionName))]
[DataContract]
[XmlRoot("FunctionName", Namespace = "DocumentModel.Math")]
public partial class FunctionName : OfficeMathArgumentType<DXM.FunctionName>
{
  /// <summary>
  ///   Specifies properties of argument object.
  /// </summary>
  public ArgumentProperties? ArgumentProperties { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  ///   Specifies formatting of argument object.
  /// </summary>
  public ControlProperties? ControlProperties { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}