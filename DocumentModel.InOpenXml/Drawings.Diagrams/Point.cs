namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Point.
/// </summary>
[OpenXmlType(typeof(DXDD.Point))]
public class Point : ModelElement<DXDD.Point>
{
 /// <summary>
 ///   Model Identifier
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Point.ModelId))]
 public string? ModelId { get; set; }

 /// <summary>
 ///   Point Type
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Point.Type))]
 public Point? Type { get; set; }

 /// <summary>
 ///   Connection Identifier
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Point.ConnectionId))]
 public string? ConnectionId { get; set; }

 /// <summary>
 ///   Property Set.
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Point.PropertySet))]
 public PropertySet? PropertySet { get; set; }

 /// <summary>
 ///   Shape Properties.
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Point.ShapeProperties))]
 public ShapeProperties? ShapeProperties { get; set; }

 /// <summary>
 ///   Text Body.
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Point.TextBody))]
 public TextBody? TextBody { get; set; }

 /// <summary>
 ///   PtExtensionList.
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Point.PtExtensionList))]
 public PtExtensionList? PtExtensionList { get; set; }
}