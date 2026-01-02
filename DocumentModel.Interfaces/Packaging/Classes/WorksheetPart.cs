namespace DocumentModel.Packaging;

/// <summary>
///   Defines the WorksheetPart
/// </summary>
public class WorksheetPart: ModelElement
{
  public string? ContentType { get; set; }
  /// <summary>
  ///   Gets the ControlPropertiesParts of the WorksheetPart
  /// </summary>
  public Collection<ControlPropertiesPart>? ControlPropertiesParts { get; set; }
  /// <summary>
  ///   Gets the CustomPropertyParts of the WorksheetPart
  /// </summary>
  public Collection<CustomPropertyPart>? CustomPropertyParts { get; set; }
  /// <summary>
  ///   Gets the EmbeddedControlPersistenceBinaryDataParts of the WorksheetPart
  /// </summary>
  public Collection<EmbeddedControlPersistenceBinaryDataPart>? EmbeddedControlPersistenceBinaryDataParts { get; set; }
  /// <summary>
  ///   Gets the EmbeddedControlPersistenceParts of the WorksheetPart
  /// </summary>
  public Collection<EmbeddedControlPersistencePart>? EmbeddedControlPersistenceParts { get; set; }
  /// <summary>
  ///   Gets the EmbeddedObjectParts of the WorksheetPart
  /// </summary>
  public Collection<EmbeddedObjectPart>? EmbeddedObjectParts { get; set; }
  /// <summary>
  ///   Gets the EmbeddedPackageParts of the WorksheetPart
  /// </summary>
  public Collection<EmbeddedPackagePart>? EmbeddedPackageParts { get; set; }
  /// <summary>
  ///   Gets the ImageParts of the WorksheetPart
  /// </summary>
  public Collection<ImagePart>? ImageParts { get; set; }
  /// <summary>
  ///   Gets the Model3DReferenceRelationshipParts of the WorksheetPart
  /// </summary>
  public Collection<Model3DReferenceRelationshipPart>? Model3DReferenceRelationshipParts { get; set; }
  /// <summary>
  ///   Gets the NamedSheetViewsParts of the WorksheetPart
  /// </summary>
  public Collection<NamedSheetViewsPart>? NamedSheetViewsParts { get; set; }
  /// <summary>
  ///   Gets the PivotTableParts of the WorksheetPart
  /// </summary>
  public Collection<PivotTablePart>? PivotTableParts { get; set; }
  /// <summary>
  ///   Gets the QueryTableParts of the WorksheetPart
  /// </summary>
  public Collection<QueryTablePart>? QueryTableParts { get; set; }
  public string? RelationshipType { get; set; }
  /// <summary>
  ///   Gets the SlicersParts of the WorksheetPart
  /// </summary>
  public Collection<SlicersPart>? SlicersParts { get; set; }
  /// <summary>
  ///   Gets the SpreadsheetPrinterSettingsParts of the WorksheetPart
  /// </summary>
  public Collection<SpreadsheetPrinterSettingsPart>? SpreadsheetPrinterSettingsParts { get; set; }
  /// <summary>
  ///   Gets the TableDefinitionParts of the WorksheetPart
  /// </summary>
  public Collection<TableDefinitionPart>? TableDefinitionParts { get; set; }
  /// <summary>
  ///   Gets the TimeLineParts of the WorksheetPart
  /// </summary>
  public Collection<TimeLinePart>? TimeLineParts { get; set; }
  /// <summary>
  ///   Gets the VmlDrawingParts of the WorksheetPart
  /// </summary>
  public Collection<VmlDrawingPart>? VmlDrawingParts { get; set; }
  /// <summary>
  ///   Gets the WorksheetThreadedCommentsParts of the WorksheetPart
  /// </summary>
  public Collection<WorksheetThreadedCommentsPart>? WorksheetThreadedCommentsParts { get; set; }
}