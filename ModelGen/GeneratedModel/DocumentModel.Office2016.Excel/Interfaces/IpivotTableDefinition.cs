namespace DocumentModel.Office2016.Excel;

public interface IpivotTableDefinition // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public string? Name { get ; set; }

  public uint? CacheId { get ; set; }

  public bool? DataOnRows { get ; set; }

  public uint? DataPosition { get ; set; }

  public uint? AutoFormatId { get ; set; }

  public bool? ApplyNumberFormats { get ; set; }

  public bool? ApplyBorderFormats { get ; set; }

  public bool? ApplyFontFormats { get ; set; }

  public bool? ApplyPatternFormats { get ; set; }

  public bool? ApplyAlignmentFormats { get ; set; }

  public bool? ApplyWidthHeightFormats { get ; set; }

  public string? DataCaption { get ; set; }

  public string? GrandTotalCaption { get ; set; }

  public string? ErrorCaption { get ; set; }

  public bool? ShowError { get ; set; }

  public string? MissingCaption { get ; set; }

  public bool? ShowMissing { get ; set; }

  public string? PageStyle { get ; set; }

  public string? PivotTableStyleName { get ; set; }

  public string? VacatedStyle { get ; set; }

  public string? Tag { get ; set; }

  public byte? UpdatedVersion { get ; set; }

  public byte? MinRefreshableVersion { get ; set; }

  public bool? AsteriskTotals { get ; set; }

  public bool? ShowItems { get ; set; }

  public bool? EditData { get ; set; }

  public bool? DisableFieldList { get ; set; }

  public bool? ShowCalculatedMembers { get ; set; }

  public bool? VisualTotals { get ; set; }

  public bool? ShowMultipleLabel { get ; set; }

  public bool? ShowDataDropDown { get ; set; }

  public bool? ShowDrill { get ; set; }

  public bool? PrintDrill { get ; set; }

  public bool? ShowMemberPropertyTips { get ; set; }

  public bool? ShowDataTips { get ; set; }

  public bool? EnableWizard { get ; set; }

  public bool? EnableDrill { get ; set; }

  public bool? EnableFieldProperties { get ; set; }

  public bool? PreserveFormatting { get ; set; }

  public bool? UseAutoFormatting { get ; set; }

  public uint? PageWrap { get ; set; }

  public bool? PageOverThenDown { get ; set; }

  public bool? SubtotalHiddenItems { get ; set; }

  public bool? RowGrandTotals { get ; set; }

  public bool? ColumnGrandTotals { get ; set; }

  public bool? FieldPrintTitles { get ; set; }

  public bool? ItemPrintTitles { get ; set; }

  public bool? MergeItem { get ; set; }

  public bool? ShowDropZones { get ; set; }

  public byte? CreatedVersion { get ; set; }

  public uint? Indent { get ; set; }

  public bool? ShowEmptyRow { get ; set; }

  public bool? ShowEmptyColumn { get ; set; }

  public bool? ShowHeaders { get ; set; }

  public bool? Compact { get ; set; }

  public bool? Outline { get ; set; }

  public bool? OutlineData { get ; set; }

  public bool? CompactData { get ; set; }

  public bool? Published { get ; set; }

  public bool? GridDropZones { get ; set; }

  public bool? StopImmersiveUi { get ; set; }

  public bool? MultipleFieldFilters { get ; set; }

  public uint? ChartFormat { get ; set; }

  public string? RowHeaderCaption { get ; set; }

  public string? ColumnHeaderCaption { get ; set; }

  public bool? FieldListSortAscending { get ; set; }

  public bool? MdxSubqueries { get ; set; }

  public bool? CustomListSort { get ; set; }

  public ILocation? Location { get ; set; }

  public IPivotFields? PivotFields { get ; set; }

  public IRowFields? RowFields { get ; set; }

  public IRowItems? RowItems { get ; set; }

  public IColumnFields? ColumnFields { get ; set; }

  public IColumnItems? ColumnItems { get ; set; }

  public IPageFields? PageFields { get ; set; }

  public IDataFields? DataFields { get ; set; }

  public IFormats? Formats { get ; set; }

  public DocumentModel.Spreadsheet.IConditionalFormats? ConditionalFormats { get ; set; }

  public IChartFormats? ChartFormats { get ; set; }

  public IPivotHierarchies? PivotHierarchies { get ; set; }

  public IPivotTableStyle? PivotTableStyle { get ; set; }

  public IPivotFilters? PivotFilters { get ; set; }

  public IRowHierarchiesUsage? RowHierarchiesUsage { get ; set; }

  public IColumnHierarchiesUsage? ColumnHierarchiesUsage { get ; set; }

  public IPivotTableDefinitionExtensionList? PivotTableDefinitionExtensionList { get ; set; }

}
