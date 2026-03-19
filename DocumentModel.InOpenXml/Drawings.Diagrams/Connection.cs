namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Connection.
/// </summary>
[OpenXmlType(typeof(DXDD.Connection))]
/// <summary>
/// Represents the Connection.
/// </summary>
public class Connection : ModelElement<DXDD.Connection>
{
 /// <summary>
 ///   Model Identifier
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Connection.ModelId))]
 /// <summary>
 /// Model Id.
 /// </summary>
 public string? ModelId { get; set; }

 /// <summary>
 ///   Point Type
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Connection.Type))]
 /// <summary>
 /// Type.
 /// </summary>
 public ConnectionType? Type { get; set; }

 /// <summary>
 ///   Source Identifier
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Connection.SourceId))]
 /// <summary>
 /// Source Id.
 /// </summary>
 public string? SourceId { get; set; }

 /// <summary>
 ///   Destination Identifier
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Connection.DestinationId))]
 /// <summary>
 /// Destination Id.
 /// </summary>
 public string? DestinationId { get; set; }

 /// <summary>
 ///   Source Position
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Connection.SourcePosition))]
 /// <summary>
 /// Source Position.
 /// </summary>
 public UInt32? SourcePosition { get; set; }

 /// <summary>
 ///   Destination Position
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Connection.DestinationPosition))]
 /// <summary>
 /// Destination Position.
 /// </summary>
 public UInt32? DestinationPosition { get; set; }

 /// <summary>
 ///   Parent Transition Identifier
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Connection.ParentTransitionId))]
 /// <summary>
 /// Parent Transition Id.
 /// </summary>
 public string? ParentTransitionId { get; set; }

 /// <summary>
 ///   Sibling Transition Identifier
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Connection.SiblingTransitionId))]
 /// <summary>
 /// Sibling Transition Id.
 /// </summary>
 public string? SiblingTransitionId { get; set; }

 /// <summary>
 ///   Presentation Identifier
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Connection.PresentationId))]
 /// <summary>
 /// Presentation Id.
 /// </summary>
 public string? PresentationId { get; set; }

 /// <summary>
 ///   ExtensionList.
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Connection.ExtensionList))]
 /// <summary>
 /// Extension List.
 /// </summary>
 public ExtensionList? ExtensionList { get; set; }
}

