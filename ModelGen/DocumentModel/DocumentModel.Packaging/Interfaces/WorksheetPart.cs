namespace DocumentModel.Packaging;

/// <summary>
/// Defines the WorksheetPart
/// </summary>
public interface WorksheetPart
{
  public String? ContentType { get ; set; }
  
  /// <summary>
  /// Gets the ControlPropertiesParts of the WorksheetPart
  /// </summary>
  public Collection<DocumentModel.Packaging.ControlPropertiesPart>? ControlPropertiesParts { get ; set; }
  
  /// <summary>
  /// Gets the CustomPropertyParts of the WorksheetPart
  /// </summary>
  public Collection<DocumentModel.Packaging.CustomPropertyPart>? CustomPropertyParts { get ; set; }
  
  /// <summary>
  /// Gets the EmbeddedControlPersistenceBinaryDataParts of the WorksheetPart
  /// </summary>
  public Collection<DocumentModel.Packaging.EmbeddedControlPersistenceBinaryDataPart>? EmbeddedControlPersistenceBinaryDataParts { get ; set; }
  
  /// <summary>
  /// Gets the EmbeddedControlPersistenceParts of the WorksheetPart
  /// </summary>
  public Collection<DocumentModel.Packaging.EmbeddedControlPersistencePart>? EmbeddedControlPersistenceParts { get ; set; }
  
  /// <summary>
  /// Gets the EmbeddedObjectParts of the WorksheetPart
  /// </summary>
  public Collection<DocumentModel.Packaging.EmbeddedObjectPart>? EmbeddedObjectParts { get ; set; }
  
  /// <summary>
  /// Gets the EmbeddedPackageParts of the WorksheetPart
  /// </summary>
  public Collection<DocumentModel.Packaging.EmbeddedPackagePart>? EmbeddedPackageParts { get ; set; }
  
  /// <summary>
  /// Gets the ImageParts of the WorksheetPart
  /// </summary>
  public Collection<DocumentModel.Packaging.ImagePart>? ImageParts { get ; set; }
  
  /// <summary>
  /// Gets the Model3DReferenceRelationshipParts of the WorksheetPart
  /// </summary>
  public Collection<DocumentModel.Packaging.Model3DReferenceRelationshipPart>? Model3DReferenceRelationshipParts { get ; set; }
  
  /// <summary>
  /// Gets the NamedSheetViewsParts of the WorksheetPart
  /// </summary>
  public Collection<DocumentModel.Packaging.NamedSheetViewsPart>? NamedSheetViewsParts { get ; set; }
  
  /// <summary>
  /// Gets the PivotTableParts of the WorksheetPart
  /// </summary>
  public Collection<DocumentModel.Packaging.PivotTablePart>? PivotTableParts { get ; set; }
  
  /// <summary>
  /// Gets the QueryTableParts of the WorksheetPart
  /// </summary>
  public Collection<DocumentModel.Packaging.QueryTablePart>? QueryTableParts { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
  /// <summary>
  /// Gets the SlicersParts of the WorksheetPart
  /// </summary>
  public Collection<DocumentModel.Packaging.SlicersPart>? SlicersParts { get ; set; }
  
  /// <summary>
  /// Gets the SpreadsheetPrinterSettingsParts of the WorksheetPart
  /// </summary>
  public Collection<DocumentModel.Packaging.SpreadsheetPrinterSettingsPart>? SpreadsheetPrinterSettingsParts { get ; set; }
  
  /// <summary>
  /// Gets the TableDefinitionParts of the WorksheetPart
  /// </summary>
  public Collection<DocumentModel.Packaging.TableDefinitionPart>? TableDefinitionParts { get ; set; }
  
  /// <summary>
  /// Gets the TimeLineParts of the WorksheetPart
  /// </summary>
  public Collection<DocumentModel.Packaging.TimeLinePart>? TimeLineParts { get ; set; }
  
  /// <summary>
  /// Gets the VmlDrawingParts of the WorksheetPart
  /// </summary>
  public Collection<DocumentModel.Packaging.VmlDrawingPart>? VmlDrawingParts { get ; set; }
  
  /// <summary>
  /// Gets the WorksheetThreadedCommentsParts of the WorksheetPart
  /// </summary>
  public Collection<DocumentModel.Packaging.WorksheetThreadedCommentsPart>? WorksheetThreadedCommentsParts { get ; set; }
  
}
