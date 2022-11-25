namespace DocumentModel.Spreadsheet;

/// <summary>
/// PivotTable Advanced Filter.
/// </summary>
public interface IPivotFilter // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// fld
  /// </summary>
  public System.UInt32? Field { get ; set; }
  
  /// <summary>
  /// mpFld
  /// </summary>
  public System.UInt32? MemberPropertyFieldId { get ; set; }
  
  /// <summary>
  /// type
  /// </summary>
  public DocumentModel.Spreadsheet.PivotFilterKind? Type { get ; set; }
  
  /// <summary>
  /// evalOrder
  /// </summary>
  public System.Int32? EvaluationOrder { get ; set; }
  
  /// <summary>
  /// id
  /// </summary>
  public System.UInt32? Id { get ; set; }
  
  /// <summary>
  /// iMeasureHier
  /// </summary>
  public System.UInt32? MeasureHierarchy { get ; set; }
  
  /// <summary>
  /// iMeasureFld
  /// </summary>
  public System.UInt32? MeasureField { get ; set; }
  
  /// <summary>
  /// name
  /// </summary>
  public System.String? Name { get ; set; }
  
  /// <summary>
  /// description
  /// </summary>
  public System.String? Description { get ; set; }
  
  /// <summary>
  /// stringValue1
  /// </summary>
  public System.String? StringValue1 { get ; set; }
  
  /// <summary>
  /// stringValue2
  /// </summary>
  public System.String? StringValue2 { get ; set; }
  
  /// <summary>
  /// AutoFilter.
  /// </summary>
  public DocumentModel.Spreadsheet.IAutoFilter? AutoFilter { get ; set; }
  
  /// <summary>
  /// PivotFilterExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? PivotFilterExtensionList { get ; set; }
  
}
