namespace DocumentModel.Spreadsheet;

/// <summary>
/// PivotTable Definition.
/// </summary>
public interface IPivotTableDefinition // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// name
  /// </summary>
  public System.String? Name { get ; set; }
  
  /// <summary>
  /// cacheId
  /// </summary>
  public System.UInt32? CacheId { get ; set; }
  
  /// <summary>
  /// dataOnRows
  /// </summary>
  public System.Boolean? DataOnRows { get ; set; }
  
  /// <summary>
  /// dataPosition
  /// </summary>
  public System.UInt32? DataPosition { get ; set; }
  
  /// <summary>
  /// Auto Format Id
  /// </summary>
  public System.UInt32? AutoFormatId { get ; set; }
  
  /// <summary>
  /// Apply Number Formats
  /// </summary>
  public System.Boolean? ApplyNumberFormats { get ; set; }
  
  /// <summary>
  /// Apply Border Formats
  /// </summary>
  public System.Boolean? ApplyBorderFormats { get ; set; }
  
  /// <summary>
  /// Apply Font Formats
  /// </summary>
  public System.Boolean? ApplyFontFormats { get ; set; }
  
  /// <summary>
  /// Apply Pattern Formats
  /// </summary>
  public System.Boolean? ApplyPatternFormats { get ; set; }
  
  /// <summary>
  /// Apply Alignment Formats
  /// </summary>
  public System.Boolean? ApplyAlignmentFormats { get ; set; }
  
  /// <summary>
  /// Apply Width / Height Formats
  /// </summary>
  public System.Boolean? ApplyWidthHeightFormats { get ; set; }
  
  /// <summary>
  /// dataCaption
  /// </summary>
  public System.String? DataCaption { get ; set; }
  
  /// <summary>
  /// grandTotalCaption
  /// </summary>
  public System.String? GrandTotalCaption { get ; set; }
  
  /// <summary>
  /// errorCaption
  /// </summary>
  public System.String? ErrorCaption { get ; set; }
  
  /// <summary>
  /// showError
  /// </summary>
  public System.Boolean? ShowError { get ; set; }
  
  /// <summary>
  /// missingCaption
  /// </summary>
  public System.String? MissingCaption { get ; set; }
  
  /// <summary>
  /// showMissing
  /// </summary>
  public System.Boolean? ShowMissing { get ; set; }
  
  /// <summary>
  /// pageStyle
  /// </summary>
  public System.String? PageStyle { get ; set; }
  
  /// <summary>
  /// pivotTableStyle
  /// </summary>
  public System.String? PivotTableStyleName { get ; set; }
  
  /// <summary>
  /// vacatedStyle
  /// </summary>
  public System.String? VacatedStyle { get ; set; }
  
  /// <summary>
  /// tag
  /// </summary>
  public System.String? Tag { get ; set; }
  
  /// <summary>
  /// updatedVersion
  /// </summary>
  public System.Byte? UpdatedVersion { get ; set; }
  
  /// <summary>
  /// minRefreshableVersion
  /// </summary>
  public System.Byte? MinRefreshableVersion { get ; set; }
  
  /// <summary>
  /// asteriskTotals
  /// </summary>
  public System.Boolean? AsteriskTotals { get ; set; }
  
  /// <summary>
  /// showItems
  /// </summary>
  public System.Boolean? ShowItems { get ; set; }
  
  /// <summary>
  /// editData
  /// </summary>
  public System.Boolean? EditData { get ; set; }
  
  /// <summary>
  /// disableFieldList
  /// </summary>
  public System.Boolean? DisableFieldList { get ; set; }
  
  /// <summary>
  /// showCalcMbrs
  /// </summary>
  public System.Boolean? ShowCalculatedMembers { get ; set; }
  
  /// <summary>
  /// visualTotals
  /// </summary>
  public System.Boolean? VisualTotals { get ; set; }
  
  /// <summary>
  /// showMultipleLabel
  /// </summary>
  public System.Boolean? ShowMultipleLabel { get ; set; }
  
  /// <summary>
  /// showDataDropDown
  /// </summary>
  public System.Boolean? ShowDataDropDown { get ; set; }
  
  /// <summary>
  /// showDrill
  /// </summary>
  public System.Boolean? ShowDrill { get ; set; }
  
  /// <summary>
  /// printDrill
  /// </summary>
  public System.Boolean? PrintDrill { get ; set; }
  
  /// <summary>
  /// showMemberPropertyTips
  /// </summary>
  public System.Boolean? ShowMemberPropertyTips { get ; set; }
  
  /// <summary>
  /// showDataTips
  /// </summary>
  public System.Boolean? ShowDataTips { get ; set; }
  
  /// <summary>
  /// enableWizard
  /// </summary>
  public System.Boolean? EnableWizard { get ; set; }
  
  /// <summary>
  /// enableDrill
  /// </summary>
  public System.Boolean? EnableDrill { get ; set; }
  
  /// <summary>
  /// enableFieldProperties
  /// </summary>
  public System.Boolean? EnableFieldProperties { get ; set; }
  
  /// <summary>
  /// preserveFormatting
  /// </summary>
  public System.Boolean? PreserveFormatting { get ; set; }
  
  /// <summary>
  /// useAutoFormatting
  /// </summary>
  public System.Boolean? UseAutoFormatting { get ; set; }
  
  /// <summary>
  /// pageWrap
  /// </summary>
  public System.UInt32? PageWrap { get ; set; }
  
  /// <summary>
  /// pageOverThenDown
  /// </summary>
  public System.Boolean? PageOverThenDown { get ; set; }
  
  /// <summary>
  /// subtotalHiddenItems
  /// </summary>
  public System.Boolean? SubtotalHiddenItems { get ; set; }
  
  /// <summary>
  /// rowGrandTotals
  /// </summary>
  public System.Boolean? RowGrandTotals { get ; set; }
  
  /// <summary>
  /// colGrandTotals
  /// </summary>
  public System.Boolean? ColumnGrandTotals { get ; set; }
  
  /// <summary>
  /// fieldPrintTitles
  /// </summary>
  public System.Boolean? FieldPrintTitles { get ; set; }
  
  /// <summary>
  /// itemPrintTitles
  /// </summary>
  public System.Boolean? ItemPrintTitles { get ; set; }
  
  /// <summary>
  /// mergeItem
  /// </summary>
  public System.Boolean? MergeItem { get ; set; }
  
  /// <summary>
  /// showDropZones
  /// </summary>
  public System.Boolean? ShowDropZones { get ; set; }
  
  /// <summary>
  /// createdVersion
  /// </summary>
  public System.Byte? CreatedVersion { get ; set; }
  
  /// <summary>
  /// indent
  /// </summary>
  public System.UInt32? Indent { get ; set; }
  
  /// <summary>
  /// showEmptyRow
  /// </summary>
  public System.Boolean? ShowEmptyRow { get ; set; }
  
  /// <summary>
  /// showEmptyCol
  /// </summary>
  public System.Boolean? ShowEmptyColumn { get ; set; }
  
  /// <summary>
  /// showHeaders
  /// </summary>
  public System.Boolean? ShowHeaders { get ; set; }
  
  /// <summary>
  /// compact
  /// </summary>
  public System.Boolean? Compact { get ; set; }
  
  /// <summary>
  /// outline
  /// </summary>
  public System.Boolean? Outline { get ; set; }
  
  /// <summary>
  /// outlineData
  /// </summary>
  public System.Boolean? OutlineData { get ; set; }
  
  /// <summary>
  /// compactData
  /// </summary>
  public System.Boolean? CompactData { get ; set; }
  
  /// <summary>
  /// published
  /// </summary>
  public System.Boolean? Published { get ; set; }
  
  /// <summary>
  /// gridDropZones
  /// </summary>
  public System.Boolean? GridDropZones { get ; set; }
  
  /// <summary>
  /// immersive
  /// </summary>
  public System.Boolean? StopImmersiveUi { get ; set; }
  
  /// <summary>
  /// multipleFieldFilters
  /// </summary>
  public System.Boolean? MultipleFieldFilters { get ; set; }
  
  /// <summary>
  /// chartFormat
  /// </summary>
  public System.UInt32? ChartFormat { get ; set; }
  
  /// <summary>
  /// rowHeaderCaption
  /// </summary>
  public System.String? RowHeaderCaption { get ; set; }
  
  /// <summary>
  /// colHeaderCaption
  /// </summary>
  public System.String? ColumnHeaderCaption { get ; set; }
  
  /// <summary>
  /// fieldListSortAscending
  /// </summary>
  public System.Boolean? FieldListSortAscending { get ; set; }
  
  /// <summary>
  /// mdxSubqueries
  /// </summary>
  public System.Boolean? MdxSubqueries { get ; set; }
  
  /// <summary>
  /// customListSort
  /// </summary>
  public System.Boolean? CustomListSort { get ; set; }
  
  /// <summary>
  /// Location.
  /// </summary>
  public DocumentModel.Spreadsheet.ILocation? Location { get ; set; }
  
  /// <summary>
  /// PivotFields.
  /// </summary>
  public DocumentModel.Spreadsheet.IPivotFields? PivotFields { get ; set; }
  
  /// <summary>
  /// RowFields.
  /// </summary>
  public DocumentModel.Spreadsheet.IRowFields? RowFields { get ; set; }
  
  /// <summary>
  /// RowItems.
  /// </summary>
  public DocumentModel.Spreadsheet.IRowItems? RowItems { get ; set; }
  
  /// <summary>
  /// ColumnFields.
  /// </summary>
  public DocumentModel.Spreadsheet.IColumnFields? ColumnFields { get ; set; }
  
  /// <summary>
  /// ColumnItems.
  /// </summary>
  public DocumentModel.Spreadsheet.IColumnItems? ColumnItems { get ; set; }
  
  /// <summary>
  /// PageFields.
  /// </summary>
  public DocumentModel.Spreadsheet.IPageFields? PageFields { get ; set; }
  
  /// <summary>
  /// DataFields.
  /// </summary>
  public DocumentModel.Spreadsheet.IDataFields? DataFields { get ; set; }
  
  /// <summary>
  /// Formats.
  /// </summary>
  public DocumentModel.Spreadsheet.IFormats? Formats { get ; set; }
  
  /// <summary>
  /// ConditionalFormats.
  /// </summary>
  public DocumentModel.Spreadsheet.IConditionalFormats? ConditionalFormats { get ; set; }
  
  /// <summary>
  /// ChartFormats.
  /// </summary>
  public DocumentModel.Spreadsheet.IChartFormats? ChartFormats { get ; set; }
  
  /// <summary>
  /// PivotHierarchies.
  /// </summary>
  public DocumentModel.Spreadsheet.IPivotHierarchies? PivotHierarchies { get ; set; }
  
  /// <summary>
  /// PivotTableStyle.
  /// </summary>
  public DocumentModel.Spreadsheet.IPivotTableStyle? PivotTableStyle { get ; set; }
  
  /// <summary>
  /// PivotFilters.
  /// </summary>
  public DocumentModel.Spreadsheet.IPivotFilters? PivotFilters { get ; set; }
  
  /// <summary>
  /// RowHierarchiesUsage.
  /// </summary>
  public DocumentModel.Spreadsheet.IRowHierarchiesUsage? RowHierarchiesUsage { get ; set; }
  
  /// <summary>
  /// ColumnHierarchiesUsage.
  /// </summary>
  public DocumentModel.Spreadsheet.IColumnHierarchiesUsage? ColumnHierarchiesUsage { get ; set; }
  
  /// <summary>
  /// PivotTableDefinitionExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? PivotTableDefinitionExtensionList { get ; set; }
  
}
