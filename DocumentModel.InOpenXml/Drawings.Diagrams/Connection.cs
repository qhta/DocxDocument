namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Connection.
/// </summary>
[OpenXmlType(typeof(DXDD.Connection))]
public class Connection : ModelElement<DXDD.Connection>
{
 /// <summary>
 ///   Model Identifier
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Connection.ModelId))]
 public string? ModelId { get; set; }

 /// <summary>
 ///   Point Type
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Connection.Type))]
 public ConnectionType? Type { get; set; }

 /// <summary>
 ///   Source Identifier
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Connection.SourceId))]
 public string? SourceId { get; set; }

 /// <summary>
 ///   Destination Identifier
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Connection.DestinationId))]
 public string? DestinationId { get; set; }

 /// <summary>
 ///   Source Position
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Connection.SourcePosition))]
 public UInt32? SourcePosition { get; set; }

 /// <summary>
 ///   Destination Position
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Connection.DestinationPosition))]
 public UInt32? DestinationPosition { get; set; }

 /// <summary>
 ///   Parent Transition Identifier
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Connection.ParentTransitionId))]
 public string? ParentTransitionId { get; set; }

 /// <summary>
 ///   Sibling Transition Identifier
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Connection.SiblingTransitionId))]
 public string? SiblingTransitionId { get; set; }

 /// <summary>
 ///   Presentation Identifier
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Connection.PresentationId))]
 public string? PresentationId { get; set; }

 /// <summary>
 ///   ExtensionList.
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Connection.ExtensionList))]
 public ExtensionList? ExtensionList { get; set; }
}