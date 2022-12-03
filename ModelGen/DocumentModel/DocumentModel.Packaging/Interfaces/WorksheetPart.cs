namespace DocumentModel.Packaging;

/// <summary>
/// Defines the WorksheetPart
/// </summary>
[ContentMime("application/vnd.openxmlformats-officedocument.spreadsheetml.worksheet+xml")]
[RelationshipUri("http://schemas.openxmlformats.org/officeDocument/2006/relationships/worksheet")]
[PartConstraint(typeof(DocumentModel.Packaging.SpreadsheetPrinterSettingsPart), false, true)]
[PartConstraint(typeof(DocumentModel.Packaging.DrawingsPart), false, false)]
[PartConstraint(typeof(DocumentModel.Packaging.VmlDrawingPart), false, true)]
[PartConstraint(typeof(DocumentModel.Packaging.WorksheetCommentsPart), false, false)]
[PartConstraint(typeof(DocumentModel.Packaging.PivotTablePart), false, true)]
[PartConstraint(typeof(DocumentModel.Packaging.SingleCellTablePart), false, false)]
[PartConstraint(typeof(DocumentModel.Packaging.TableDefinitionPart), false, true)]
[PartConstraint(typeof(DocumentModel.Packaging.EmbeddedControlPersistencePart), false, true)]
[PartConstraint(typeof(DocumentModel.Packaging.ControlPropertiesPart), false, true)]
[PartConstraint(typeof(DocumentModel.Packaging.EmbeddedObjectPart), false, true)]
[PartConstraint(typeof(DocumentModel.Packaging.EmbeddedPackagePart), false, true)]
[PartConstraint(typeof(DocumentModel.Packaging.ImagePart), false, true)]
[PartConstraint(typeof(DocumentModel.Packaging.CustomPropertyPart), false, true)]
[PartConstraint(typeof(DocumentModel.Packaging.WorksheetSortMapPart), false, false)]
[PartConstraint(typeof(DocumentModel.Packaging.QueryTablePart), false, true)]
[PartConstraint(typeof(DocumentModel.Packaging.EmbeddedControlPersistenceBinaryDataPart), false, true)]
[PartConstraint(typeof(DocumentModel.Packaging.SlicersPart), false, true)]
[PartConstraint(typeof(DocumentModel.Packaging.TimeLinePart), false, true)]
[PartConstraint(typeof(DocumentModel.Packaging.WorksheetThreadedCommentsPart), false, true)]
[PartConstraint(typeof(DocumentModel.Packaging.Model3DReferenceRelationshipPart), false, true)]
[PartConstraint(typeof(DocumentModel.Packaging.NamedSheetViewsPart), false, true)]
public interface WorksheetPart // : DocumentModel.Packaging.OpenXmlPart
{
  public String? ContentType { get ; set; }
  
  /// <summary>
  /// Gets the ControlPropertiesParts of the WorksheetPart
  /// </summary>
  public ControlPropertiesPart? ControlPropertiesParts { get ; set; }
  
  /// <summary>
  /// Gets the CustomPropertyParts of the WorksheetPart
  /// </summary>
  public CustomPropertyPart? CustomPropertyParts { get ; set; }
  
  /// <summary>
  /// Gets the EmbeddedControlPersistenceBinaryDataParts of the WorksheetPart
  /// </summary>
  public EmbeddedControlPersistenceBinaryDataPart? EmbeddedControlPersistenceBinaryDataParts { get ; set; }
  
  /// <summary>
  /// Gets the EmbeddedControlPersistenceParts of the WorksheetPart
  /// </summary>
  public EmbeddedControlPersistencePart? EmbeddedControlPersistenceParts { get ; set; }
  
  /// <summary>
  /// Gets the EmbeddedObjectParts of the WorksheetPart
  /// </summary>
  public EmbeddedObjectPart? EmbeddedObjectParts { get ; set; }
  
  /// <summary>
  /// Gets the EmbeddedPackageParts of the WorksheetPart
  /// </summary>
  public EmbeddedPackagePart? EmbeddedPackageParts { get ; set; }
  
  /// <summary>
  /// Gets the ImageParts of the WorksheetPart
  /// </summary>
  public ImagePart? ImageParts { get ; set; }
  
  /// <summary>
  /// Gets the Model3DReferenceRelationshipParts of the WorksheetPart
  /// </summary>
  public Model3DReferenceRelationshipPart? Model3DReferenceRelationshipParts { get ; set; }
  
  /// <summary>
  /// Gets the NamedSheetViewsParts of the WorksheetPart
  /// </summary>
  public NamedSheetViewsPart? NamedSheetViewsParts { get ; set; }
  
  /// <summary>
  /// Gets the PivotTableParts of the WorksheetPart
  /// </summary>
  public PivotTablePart? PivotTableParts { get ; set; }
  
  /// <summary>
  /// Gets the QueryTableParts of the WorksheetPart
  /// </summary>
  public QueryTablePart? QueryTableParts { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
  /// <summary>
  /// Gets the SlicersParts of the WorksheetPart
  /// </summary>
  public SlicersPart? SlicersParts { get ; set; }
  
  /// <summary>
  /// Gets the SpreadsheetPrinterSettingsParts of the WorksheetPart
  /// </summary>
  public SpreadsheetPrinterSettingsPart? SpreadsheetPrinterSettingsParts { get ; set; }
  
  /// <summary>
  /// Gets the TableDefinitionParts of the WorksheetPart
  /// </summary>
  public TableDefinitionPart? TableDefinitionParts { get ; set; }
  
  /// <summary>
  /// Gets the TimeLineParts of the WorksheetPart
  /// </summary>
  public TimeLinePart? TimeLineParts { get ; set; }
  
  /// <summary>
  /// Gets the VmlDrawingParts of the WorksheetPart
  /// </summary>
  public VmlDrawingPart? VmlDrawingParts { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Spreadsheet.Worksheet? Worksheet { get ; set; }
  
  /// <summary>
  /// Gets the WorksheetThreadedCommentsParts of the WorksheetPart
  /// </summary>
  public WorksheetThreadedCommentsPart? WorksheetThreadedCommentsParts { get ; set; }
  
}
