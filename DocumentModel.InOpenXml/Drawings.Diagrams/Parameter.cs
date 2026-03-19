namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Parameter.
/// </summary>
[OpenXmlType(typeof(DXDD.Parameter))]
/// <summary>
/// Represents the Parameter.
/// </summary>
public class Parameter : ModelElement<DXDD.Parameter>
{
 /// <summary>
 ///   Parameter Type
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Parameter.Type))]
 /// <summary>
 /// Type.
 /// </summary>
 public ParameterId? Type { get; set; }

 /// <summary>
 ///   Value
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Parameter.Val))]
 /// <summary>
 /// Val.
 /// </summary>
 public string? Val { get; set; }
}

