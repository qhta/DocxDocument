namespace DocumentModel.Packaging;

/// <summary>
///   Defines the WorksheetPart
/// </summary>
public interface WorksheetPart: OpenXmlPart
{
  public string? ContentType { get; set; }
  /// <summary>
  ///   Gets the ControlPropertiesParts of the WorksheetPart
  /// </summary>
  public ControlPropertiesParts ControlPropertiesParts { get; set; }
  /// <summary>
  ///   Gets the CustomPropertyParts of the WorksheetPart
  /// </summary>
  public CustomPropertyParts CustomPropertyParts { get; set; }
  /// <summary>
  ///   Gets the EmbeddedControlPersistenceBinaryDataParts of the WorksheetPart
  /// </summary>
  public EmbeddedControlPersistenceBinaryDataParts EmbeddedControlPersistenceBinaryDataParts { get; set; }
  /// <summary>
  ///   Gets the EmbeddedControlPersistenceParts of the WorksheetPart
  /// </summary>
  public EmbeddedControlPersistenceParts EmbeddedControlPersistenceParts { get; set; }
  /// <summary>
  ///   Gets the EmbeddedObjectParts of the WorksheetPart
  /// </summary>
  public EmbeddedObjectParts EmbeddedObjectParts { get; set; }
  /// <summary>
  ///   Gets the EmbeddedPackageParts of the WorksheetPart
  /// </summary>
  public EmbeddedPackageParts EmbeddedPackageParts { get; set; }
  /// <summary>
  ///   Gets the ImageParts of the WorksheetPart
  /// </summary>
  public ImageParts ImageParts { get; set; }
  /// <summary>
  ///   Gets the Model3DReferenceRelationshipParts of the WorksheetPart
  /// </summary>
  public Model3DReferenceRelationshipParts Model3DReferenceRelationshipParts { get; set; }
  /// <summary>
  ///   Gets the NamedSheetViewsParts of the WorksheetPart
  /// </summary>
  public NamedSheetViewsParts NamedSheetViewsParts { get; set; }
  /// <summary>
  ///   Gets the PivotTableParts of the WorksheetPart
  /// </summary>
  public PivotTableParts PivotTableParts { get; set; }
  /// <summary>
  ///   Gets the QueryTableParts of the WorksheetPart
  /// </summary>
  public QueryTableParts QueryTableParts { get; set; }
  public string? RelationshipType { get; set; }
  /// <summary>
  ///   Gets the SlicersParts of the WorksheetPart
  /// </summary>
  public SlicersParts SlicersParts { get; set; }
  /// <summary>
  ///   Gets the SpreadsheetPrinterSettingsParts of the WorksheetPart
  /// </summary>
  public SpreadsheetPrinterSettingsParts SpreadsheetPrinterSettingsParts { get; set; }
  /// <summary>
  ///   Gets the TableDefinitionParts of the WorksheetPart
  /// </summary>
  public TableDefinitionParts TableDefinitionParts { get; set; }
  /// <summary>
  ///   Gets the TimeLineParts of the WorksheetPart
  /// </summary>
  public TimeLineParts TimeLineParts { get; set; }
  /// <summary>
  ///   Gets the VmlDrawingParts of the WorksheetPart
  /// </summary>
  public VmlDrawingParts VmlDrawingParts { get; set; }
  /// <summary>
  ///   Gets the WorksheetThreadedCommentsParts of the WorksheetPart
  /// </summary>
  public WorksheetThreadedCommentsParts WorksheetThreadedCommentsParts { get; set; }
}