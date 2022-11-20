namespace DocumentModel.Spreadsheet;

/// <summary>
/// PivotTable Advanced Filter.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IAutoFilter))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IPivotFilterExtensionList))]
public class PivotFilter: IPivotFilter
{
  /// <summary>
  /// fld
  /// </summary>
  public uint? Field
  {
    get;
    set;
  }
  
  /// <summary>
  /// mpFld
  /// </summary>
  public uint? MemberPropertyFieldId
  {
    get;
    set;
  }
  
  /// <summary>
  /// type
  /// </summary>
  public PivotFilterValues? Type
  {
    get;
    set;
  }
  
  /// <summary>
  /// evalOrder
  /// </summary>
  public int? EvaluationOrder
  {
    get;
    set;
  }
  
  /// <summary>
  /// id
  /// </summary>
  public uint? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// iMeasureHier
  /// </summary>
  public uint? MeasureHierarchy
  {
    get;
    set;
  }
  
  /// <summary>
  /// iMeasureFld
  /// </summary>
  public uint? MeasureField
  {
    get;
    set;
  }
  
  /// <summary>
  /// name
  /// </summary>
  public string? Name
  {
    get;
    set;
  }
  
  /// <summary>
  /// description
  /// </summary>
  public string? Description
  {
    get;
    set;
  }
  
  /// <summary>
  /// stringValue1
  /// </summary>
  public string? StringValue1
  {
    get;
    set;
  }
  
  /// <summary>
  /// stringValue2
  /// </summary>
  public string? StringValue2
  {
    get;
    set;
  }
  
  /// <summary>
  /// AutoFilter.
  /// </summary>
  public DocumentModel.Spreadsheet.IAutoFilter? AutoFilter
  {
    get;
    set;
  }
  
  /// <summary>
  /// PivotFilterExtensionList.
  /// </summary>
  public IPivotFilterExtensionList? PivotFilterExtensionList
  {
    get;
    set;
  }
  
}
