using DocumentModel.Wordprocessing;

namespace DocumentModel.Math;
/// <summary>
///   Super (upper) argument in PreSubSuper and N-ary objects.
/// </summary>
[OpenXmlType(typeof(DXM.SuperArgument))]
[DataContract]
[XmlRoot("SuperArgument", Namespace = "DocumentModel.Math")]
public class SuperArgument : OfficeMathArgumentType<DXM.SuperArgument>
{
}