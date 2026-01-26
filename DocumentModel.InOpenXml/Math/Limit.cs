namespace DocumentModel.Math;
/// <summary>
///   This element specifies the lower limit of the limLow object and the upper limit of the limUpp function.
/// </summary>
[OpenXmlType(typeof(DXM.Limit))]
public partial class Limit : OfficeMathArgumentType<DXM.Limit>
{
 /// <summary>
 ///   Specifies properties of argument object.
 /// </summary>
 public ArgumentProperties? ArgumentProperties { get; set; }
 /// <summary>
 ///   Specifies formatting of argument object.
 /// </summary>
 public ControlProperties? ControlProperties { get; set; }
}