namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Point.
/// </summary>
[OpenXmlType(typeof(DXDD.Point))]
/// <summary>
/// Represents the Point.
/// </summary>
public class Point : ModelElement<DXDD.Point>
{
 /// <summary>
 ///   Model Identifier
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Point.ModelId))]
 /// <summary>
 /// Model Id.
 /// </summary>
 public string? ModelId { get; set; }

 /// <summary>
 ///   Point Type
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Point.Type))]
 /// <summary>
 /// Type.
 /// </summary>
 public Point? Type { get; set; }

 /// <summary>
 ///   Connection Identifier
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Point.ConnectionId))]
 /// <summary>
 /// Connection Id.
 /// </summary>
 public string? ConnectionId { get; set; }

 /// <summary>
 ///   Property Set.
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Point.PropertySet))]
 /// <summary>
 /// Property Set.
 /// </summary>
 public PropertySet? PropertySet { get; set; }

 /// <summary>
 ///   Shape Properties.
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Point.ShapeProperties))]
 /// <summary>
 /// Shape Properties.
 /// </summary>
 public ShapeProperties? ShapeProperties { get; set; }

 /// <summary>
 ///   Text Body.
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Point.TextBody))]
 /// <summary>
 /// Text Body.
 /// </summary>
 public TextBody? TextBody { get; set; }

 /// <summary>
 ///   PtExtensionList.
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Point.PtExtensionList))]
 /// <summary>
 /// Pt Extension List.
 /// </summary>
 public PtExtensionList? PtExtensionList { get; set; }
}

