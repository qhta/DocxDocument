namespace DocumentModel.Packaging;

/// <summary>
/// Defines the WorksheetPart
/// </summary>
public class WorksheetPartImpl: DocumentModel.Packaging.OpenXmlPartContainerImpl, WorksheetPart
{
  /// <summary>
  /// Gets the ControlPropertiesParts of the WorksheetPart
  /// </summary>
  public OpenXmlPartContainer? ControlPropertiesParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the CustomPropertyParts of the WorksheetPart
  /// </summary>
  public OpenXmlPartContainer? CustomPropertyParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the EmbeddedControlPersistenceBinaryDataParts of the WorksheetPart
  /// </summary>
  public OpenXmlPartContainer? EmbeddedControlPersistenceBinaryDataParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the EmbeddedControlPersistenceParts of the WorksheetPart
  /// </summary>
  public EmbeddedControlPersistencePart? EmbeddedControlPersistenceParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the EmbeddedObjectParts of the WorksheetPart
  /// </summary>
  public OpenXmlPartContainer? EmbeddedObjectParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the EmbeddedPackageParts of the WorksheetPart
  /// </summary>
  public OpenXmlPartContainer? EmbeddedPackageParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the ImageParts of the WorksheetPart
  /// </summary>
  public OpenXmlPartContainer? ImageParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the Model3DReferenceRelationshipParts of the WorksheetPart
  /// </summary>
  public OpenXmlPartContainer? Model3DReferenceRelationshipParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the NamedSheetViewsParts of the WorksheetPart
  /// </summary>
  public OpenXmlPartContainer? NamedSheetViewsParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the PivotTableParts of the WorksheetPart
  /// </summary>
  public OpenXmlPartContainer? PivotTableParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the QueryTableParts of the WorksheetPart
  /// </summary>
  public OpenXmlPartContainer? QueryTableParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the SlicersParts of the WorksheetPart
  /// </summary>
  public OpenXmlPartContainer? SlicersParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the SpreadsheetPrinterSettingsParts of the WorksheetPart
  /// </summary>
  public OpenXmlPartContainer? SpreadsheetPrinterSettingsParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the TableDefinitionParts of the WorksheetPart
  /// </summary>
  public TableDefinitionPart? TableDefinitionParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the TimeLineParts of the WorksheetPart
  /// </summary>
  public OpenXmlPartContainer? TimeLineParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the VmlDrawingParts of the WorksheetPart
  /// </summary>
  public VmlDrawingPart? VmlDrawingParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the WorksheetThreadedCommentsParts of the WorksheetPart
  /// </summary>
  public OpenXmlPartContainer? WorksheetThreadedCommentsParts
  {
    get;
    set;
  }
  
}
