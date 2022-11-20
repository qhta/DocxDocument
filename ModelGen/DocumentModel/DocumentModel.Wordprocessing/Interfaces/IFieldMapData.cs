namespace DocumentModel.Wordprocessing;

/// <summary>
/// External Data Source to Merge Field Mapping.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ILanguageId))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IMailMergeFieldType))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IDynamicAddress))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IName))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IMappedName))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IColumnIndex))]
public interface IFieldMapData // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Merge Field Mapping.
  /// </summary>
  public IMailMergeFieldType? MailMergeFieldType { get ; set; }
  
  /// <summary>
  /// Data Source Name for Column.
  /// </summary>
  public IName? Name { get ; set; }
  
  /// <summary>
  /// Predefined Merge Field Name.
  /// </summary>
  public IMappedName? MappedName { get ; set; }
  
  /// <summary>
  /// Index of Column Being Mapped.
  /// </summary>
  public IColumnIndex? ColumnIndex { get ; set; }
  
  /// <summary>
  /// Merge Field Name Language ID.
  /// </summary>
  public ILanguageId? LanguageId { get ; set; }
  
  /// <summary>
  /// Use Country/Region-Based Address Field Ordering.
  /// </summary>
  public IDynamicAddress? DynamicAddress { get ; set; }
  
}
