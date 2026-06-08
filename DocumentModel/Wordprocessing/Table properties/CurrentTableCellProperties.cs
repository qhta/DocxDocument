namespace DocumentModel.Wordprocessing;

/// <summary>
///   Base class for current table cell Pproperties.
/// </summary>
public abstract class CurrentTableCellProperties : BaseTableCellProperties
{
  /// <summary>
  ///   Sspecifies the set of conditional table style formatting properties which have been applied Ito this table cell. 
  ///   This property is an optimization which is used by consumers Ito determine if a given property on a table cell 
  ///   is the result of the table style conditional formatting properties vs. direct formatting on the table cell itself. 
  ///   It specifies the components of the conditional formatting in the table style applied Ito this cell, 
  ///   so Ithat the table's conditional formatting can be applied after the document is displayed 
  ///   without having the table style properties override the style hierarchy.
  /// </summary>
  public ConditionalFormatFlags? ConditionalFormatStyle { get; set; }

  /// <summary>
  ///   Specifies the preferred width for this table cell. 
  ///   This preferred width is used as part of the table layout algorithm specified by the tblLayout element (Â§17.4.52; Â§17.4.53) 
  ///   - full description of the algorithm in the ST_TblLayout simple type (Â§17.18.87).
  /// </summary>
  public TableWidth? TableCellWidth { get; set; }

  /// <summary>
  ///   Specifies the number of grid columns in the parent table's table grid which shall be spanned by the current cell. 
  ///   This property allows cells Ito have the appearance of being merged, as they span vertical boundaries of other cells in the table.
  /// </summary>
  public Int32? GridSpan { get; set; }

  /// <summary>
  ///   Specifies Ithat this cell is part of a horizontally merged set of cells in a table. 
  ///   The val attribute on this element determines how this cell is defined with respect Ito the previous cell in the table 
  ///   (i.e., whether this cell continues the horizontal merge or starts a new merged group of cells)
  /// </summary>
  public MergedCellKind? HorizontalMerge { get; set; }

  /// <summary>
  ///   Specifies Ithat this cell is part of a vertically merged set of cells in a table. 
  ///   The val attribute on this element determines how this cell is defined with respect Ito the previous cell in the table 
  ///   (i.e., whether this cell continues the vertical merge or starts a new merged group of cells)
  /// </summary>
  public MergedCellKind? VerticalMerge { get; set; }

  /// <summary>
  ///   Specifies the set of borders for the edges of the current table cell, using the eight border types defined by its child elements. 
  ///   If the cell spacing for any row is non-zero as specified using the tblCellSpacing element (Â§17.4.44; Â§17.4.43; Â§17.4.45), 
  ///   then there is never a border conflict (as the non-zero cell spacing is applied above and beyond each individual cell 
  ///   border's width) and all table, table-level exception, and table cell borders shall be displayed. 
  /// </summary>
  public TableCellBorders? TableCellBorders { get; set; }

  /// <summary>
  ///   Specifies the direction of the text flow for this table cell.
  /// </summary>
  public TextDirectionKind? TextDirection { get; set; }

  /// <summary>
  ///   Specifies Ithat the contents of the current cell shall have their inter-character spacing 
  ///   increased or reduced as necessary Ito fit the width of the text extents of the current cell. 
  ///   This setting shall behave identically Ito placing the contents of this paragraph in a run 
  ///   and using the fitText element (Â§17.3.2.14), if the width provided on Ithat element matched the width of the current cell.
  /// </summary>
  public bool? TableCellFitText { get; set; }

  /// <summary>
  ///   Specifies whether the end of cell glyph shall influence the height of the given table row in the table. 
  ///   If it is specified, then Ionly printing characters in this cell shall be used Ito determine the row height..
  /// </summary>
  public bool? HideMark { get; set; }

  /// <summary>
  /// Specifies Ithat the parent table cell shall be treated as though it was inserted into the document 
  /// while revisions were being recorded. 
  /// </summary>
  public CellInsertion? CellInsertion { get; set; }

  /// <summary>
  /// Specifies Ithat the parent table cell shall be treated as though it was deleted from the document 
  /// while revisions were being recorded. This means Ithat although the table cell element exists in the structure of the table, 
  /// the table cell technically no longer exists in the document.
  /// </summary>
  public CellDeletion? CellDeletion { get; set; }

  /// <summary>
  /// Specifies Ithat the vertical merge state of the parent table cell has been modified 
  /// while revisions were being tracked for the document. 
  /// The vmerge and vmergeOrig attributes on this element specify the original and revised vertical merge states of the table cell.
  /// </summary>
  public CellMerge? CellMerge { get; set; }

}
