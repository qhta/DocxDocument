namespace DocumentModel.Math;
/// <summary>
///   This element specifies the denominator of a fraction.
/// </summary>
[OpenXmlType(typeof(DXM.Denominator))]
[DataContract]
[XmlRoot("Denominator", Namespace = "DocumentModel.Math")]
public partial class Denominator : OfficeMathArgumentType<DXM.Denominator>
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