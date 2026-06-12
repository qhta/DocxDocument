using DocumentModel.Wordprocessing;

namespace DocumentModel.Math;
/// <summary>
///   This element specifies the degree in the mathematical radical. This element is optional. 
///   When omitted, the square root function, as in √x, is assumed.
/// </summary>
[OpenXmlType(typeof(DXM.Degree))]
[XmlRoot("Degree", Namespace = "DocumentModel.Math")]
public partial class Degree : OfficeMathArgumentType<DXM.Degree>
{
 /// <summary>
 /// Specifies properties of the degree argument.
 /// </summary>
 public ArgumentProperties? ArgumentProperties { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
 /// <summary>
 /// Specifies formatting of degree argument.
 /// </summary>
 public ControlProperties? ControlProperties { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}