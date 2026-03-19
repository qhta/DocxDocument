namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Parameter.
/// </summary>
[OpenXmlType(typeof(DXDD.Parameter))]
public class Parameter : ModelElement<DXDD.Parameter>
{
 /// <summary>
 ///   Parameter Type
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Parameter.Type))]
 public ParameterId? Type { get; set; }

 /// <summary>
 ///   Value
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Parameter.Val))]
 public string? Val { get; set; }
}