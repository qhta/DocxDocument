namespace DocumentModel.Office2016.Excel;

/// <summary>
/// Represents a PivotTable View..
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IChartFormats))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IColumnFields))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IColumnHierarchiesUsage))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IColumnItems))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IConditionalFormats))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IDataFields))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IFormats))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ILocation))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IPageFields))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IPivotFields))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IPivotFilters))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IPivotHierarchies))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IPivotTableDefinitionExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IPivotTableStyle))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IRowFields))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IRowHierarchiesUsage))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IRowItems))]
public interface IpivotTableDefinition // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// name
  /// </summary>
  public string? Name { get ; set; }
  
  /// <summary>
  /// cacheId
  /// </summary>
  public uint? CacheId { get ; set; }
  
  /// <summary>
  /// dataOnRows
  /// </summary>
  public bool? DataOnRows { get ; set; }
  
  /// <summary>
  /// dataPosition
  /// </summary>
  public uint? DataPosition { get ; set; }
  
  /// <summary>
  /// Auto Format Id
  /// </summary>
  public uint? AutoFormatId { get ; set; }
  
  /// <summary>
  /// Apply Number Formats
  /// </summary>
  public bool? ApplyNumberFormats { get ; set; }
  
  /// <summary>
  /// Apply Border Formats
  /// </summary>
  public bool? ApplyBorderFormats { get ; set; }
  
  /// <summary>
  /// Apply Font Formats
  /// </summary>
  public bool? ApplyFontFormats { get ; set; }
  
  /// <summary>
  /// Apply Pattern Formats
  /// </summary>
  public bool? ApplyPatternFormats { get ; set; }
  
  /// <summary>
  /// Apply Alignment Formats
  /// </summary>
  public bool? ApplyAlignmentFormats { get ; set; }
  
  /// <summary>
  /// Apply Width / Height Formats
  /// </summary>
  public bool? ApplyWidthHeightFormats { get ; set; }
  
  /// <summary>
  /// dataCaption
  /// </summary>
  public string? DataCaption { get ; set; }
  
  /// <summary>
  /// grandTotalCaption
  /// </summary>
  public string? GrandTotalCaption { get ; set; }
  
  /// <summary>
  /// errorCaption
  /// </summary>
  public string? ErrorCaption { get ; set; }
  
  /// <summary>
  /// showError
  /// </summary>
  public bool? ShowError { get ; set; }
  
  /// <summary>
  /// missingCaption
  /// </summary>
  public string? MissingCaption { get ; set; }
  
  /// <summary>
  /// showMissing
  /// </summary>
  public bool? ShowMissing { get ; set; }
  
  /// <summary>
  /// pageStyle
  /// </summary>
  public string? PageStyle { get ; set; }
  
  /// <summary>
  /// pivotTableStyle
  /// </summary>
  public string? PivotTableStyleName { get ; set; }
  
  /// <summary>
  /// vacatedStyle
  /// </summary>
  public string? VacatedStyle { get ; set; }
  
  /// <summary>
  /// tag
  /// </summary>
  public string? Tag { get ; set; }
  
  /// <summary>
  /// updatedVersion
  /// </summary>
  public byte? UpdatedVersion { get ; set; }
  
  /// <summary>
  /// minRefreshableVersion
  /// </summary>
  public byte? MinRefreshableVersion { get ; set; }
  
  /// <summary>
  /// asteriskTotals
  /// </summary>
  public bool? AsteriskTotals { get ; set; }
  
  /// <summary>
  /// showItems
  /// </summary>
  public bool? ShowItems { get ; set; }
  
  /// <summary>
  /// editData
  /// </summary>
  public bool? EditData { get ; set; }
  
  /// <summary>
  /// disableFieldList
  /// </summary>
  public bool? DisableFieldList { get ; set; }
  
  /// <summary>
  /// showCalcMbrs
  /// </summary>
  public bool? ShowCalculatedMembers { get ; set; }
  
  /// <summary>
  /// visualTotals
  /// </summary>
  public bool? VisualTotals { get ; set; }
  
  /// <summary>
  /// showMultipleLabel
  /// </summary>
  public bool? ShowMultipleLabel { get ; set; }
  
  /// <summary>
  /// showDataDropDown
  /// </summary>
  public bool? ShowDataDropDown { get ; set; }
  
  /// <summary>
  /// showDrill
  /// </summary>
  public bool? ShowDrill { get ; set; }
  
  /// <summary>
  /// printDrill
  /// </summary>
  public bool? PrintDrill { get ; set; }
  
  /// <summary>
  /// showMemberPropertyTips
  /// </summary>
  public bool? ShowMemberPropertyTips { get ; set; }
  
  /// <summary>
  /// showDataTips
  /// </summary>
  public bool? ShowDataTips { get ; set; }
  
  /// <summary>
  /// enableWizard
  /// </summary>
  public bool? EnableWizard { get ; set; }
  
  /// <summary>
  /// enableDrill
  /// </summary>
  public bool? EnableDrill { get ; set; }
  
  /// <summary>
  /// enableFieldProperties
  /// </summary>
  public bool? EnableFieldProperties { get ; set; }
  
  /// <summary>
  /// preserveFormatting
  /// </summary>
  public bool? PreserveFormatting { get ; set; }
  
  /// <summary>
  /// useAutoFormatting
  /// </summary>
  public bool? UseAutoFormatting { get ; set; }
  
  /// <summary>
  /// pageWrap
  /// </summary>
  public uint? PageWrap { get ; set; }
  
  /// <summary>
  /// pageOverThenDown
  /// </summary>
  public bool? PageOverThenDown { get ; set; }
  
  /// <summary>
  /// subtotalHiddenItems
  /// </summary>
  public bool? SubtotalHiddenItems { get ; set; }
  
  /// <summary>
  /// rowGrandTotals
  /// </summary>
  public bool? RowGrandTotals { get ; set; }
  
  /// <summary>
  /// colGrandTotals
  /// </summary>
  public bool? ColumnGrandTotals { get ; set; }
  
  /// <summary>
  /// fieldPrintTitles
  /// </summary>
  public bool? FieldPrintTitles { get ; set; }
  
  /// <summary>
  /// itemPrintTitles
  /// </summary>
  public bool? ItemPrintTitles { get ; set; }
  
  /// <summary>
  /// mergeItem
  /// </summary>
  public bool? MergeItem { get ; set; }
  
  /// <summary>
  /// showDropZones
  /// </summary>
  public bool? ShowDropZones { get ; set; }
  
  /// <summary>
  /// createdVersion
  /// </summary>
  public byte? CreatedVersion { get ; set; }
  
  /// <summary>
  /// indent
  /// </summary>
  public uint? Indent { get ; set; }
  
  /// <summary>
  /// showEmptyRow
  /// </summary>
  public bool? ShowEmptyRow { get ; set; }
  
  /// <summary>
  /// showEmptyCol
  /// </summary>
  public bool? ShowEmptyColumn { get ; set; }
  
  /// <summary>
  /// showHeaders
  /// </summary>
  public bool? ShowHeaders { get ; set; }
  
  /// <summary>
  /// compact
  /// </summary>
  public bool? Compact { get ; set; }
  
  /// <summary>
  /// outline
  /// </summary>
  public bool? Outline { get ; set; }
  
  /// <summary>
  /// outlineData
  /// </summary>
  public bool? OutlineData { get ; set; }
  
  /// <summary>
  /// compactData
  /// </summary>
  public bool? CompactData { get ; set; }
  
  /// <summary>
  /// published
  /// </summary>
  public bool? Published { get ; set; }
  
  /// <summary>
  /// gridDropZones
  /// </summary>
  public bool? GridDropZones { get ; set; }
  
  /// <summary>
  /// immersive
  /// </summary>
  public bool? StopImmersiveUi { get ; set; }
  
  /// <summary>
  /// multipleFieldFilters
  /// </summary>
  public bool? MultipleFieldFilters { get ; set; }
  
  /// <summary>
  /// chartFormat
  /// </summary>
  public uint? ChartFormat { get ; set; }
  
  /// <summary>
  /// rowHeaderCaption
  /// </summary>
  public string? RowHeaderCaption { get ; set; }
  
  /// <summary>
  /// colHeaderCaption
  /// </summary>
  public string? ColumnHeaderCaption { get ; set; }
  
  /// <summary>
  /// fieldListSortAscending
  /// </summary>
  public bool? FieldListSortAscending { get ; set; }
  
  /// <summary>
  /// mdxSubqueries
  /// </summary>
  public bool? MdxSubqueries { get ; set; }
  
  /// <summary>
  /// customListSort
  /// </summary>
  public bool? CustomListSort { get ; set; }
  
  /// <summary>
  /// Location.
  /// </summary>
  public ILocation? Location { get ; set; }
  
  /// <summary>
  /// PivotFields.
  /// </summary>
  public IPivotFields? PivotFields { get ; set; }
  
  /// <summary>
  /// RowFields.
  /// </summary>
  public IRowFields? RowFields { get ; set; }
  
  /// <summary>
  /// RowItems.
  /// </summary>
  public IRowItems? RowItems { get ; set; }
  
  /// <summary>
  /// ColumnFields.
  /// </summary>
  public IColumnFields? ColumnFields { get ; set; }
  
  /// <summary>
  /// ColumnItems.
  /// </summary>
  public IColumnItems? ColumnItems { get ; set; }
  
  /// <summary>
  /// PageFields.
  /// </summary>
  public IPageFields? PageFields { get ; set; }
  
  /// <summary>
  /// DataFields.
  /// </summary>
  public IDataFields? DataFields { get ; set; }
  
  /// <summary>
  /// Formats.
  /// </summary>
  public IFormats? Formats { get ; set; }
  
  /// <summary>
  /// ConditionalFormats.
  /// </summary>
  public DocumentModel.Spreadsheet.IConditionalFormats? ConditionalFormats { get ; set; }
  
  /// <summary>
  /// ChartFormats.
  /// </summary>
  public IChartFormats? ChartFormats { get ; set; }
  
  /// <summary>
  /// PivotHierarchies.
  /// </summary>
  public IPivotHierarchies? PivotHierarchies { get ; set; }
  
  /// <summary>
  /// PivotTableStyle.
  /// </summary>
  public IPivotTableStyle? PivotTableStyle { get ; set; }
  
  /// <summary>
  /// PivotFilters.
  /// </summary>
  public IPivotFilters? PivotFilters { get ; set; }
  
  /// <summary>
  /// RowHierarchiesUsage.
  /// </summary>
  public IRowHierarchiesUsage? RowHierarchiesUsage { get ; set; }
  
  /// <summary>
  /// ColumnHierarchiesUsage.
  /// </summary>
  public IColumnHierarchiesUsage? ColumnHierarchiesUsage { get ; set; }
  
  /// <summary>
  /// PivotTableDefinitionExtensionList.
  /// </summary>
  public IPivotTableDefinitionExtensionList? PivotTableDefinitionExtensionList { get ; set; }
  
}
