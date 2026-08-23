namespace DocumentModel.Math;
/// <summary>
///   This element specifies the numerator of the Fraction object f. 
/// </summary>
[OpenXmlType(typeof(DXM.Numerator))]
[DataContract]
[XmlRoot("Numerator", Namespace = "DocumentModel.Math")]
public partial class Numerator : OfficeMathArgumentType<DXM.Numerator>
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