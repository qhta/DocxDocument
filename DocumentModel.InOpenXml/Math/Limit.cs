namespace DocumentModel.Math;
/// <summary>
///   This element specifies the lower limit of the limLow object and the upper limit of the limUpp function.
/// </summary>
[OpenXmlType(typeof(DXM.Limit))]
[DataContract]
[XmlRoot("Limit", Namespace = "DocumentModel.Math")]
public partial class Limit : OfficeMathArgumentType<DXM.Limit>
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