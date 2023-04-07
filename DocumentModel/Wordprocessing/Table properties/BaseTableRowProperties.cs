namespace DocumentModel.Wordprocessing;

/// <summary>
///   Base class for all TableRowProperties classes.
///   Contains common properties.
/// </summary>
public abstract class BaseTableRowProperties: ModelElement
{
  /// <summary>
  /// Specifies the set of conditional table style formatting properties which have been applied to this table row. 
  /// This property is an optimization which is used by consumers to determine 
  /// if a given property on a table row is the result of the table style conditional formatting properties 
  /// vs. direct formatting on the table cell itself. 
  /// It specifies the components of the conditional formatting in the table style applied to this cell, 
  /// so that the table's conditional formatting can be applied after the document is displayed 
  /// without having the table style properties override the style hierarchy.
  /// </summary>
  public ConditionalFormatStyle? ConditionalFormatStyle { get; set; }

  /// <summary>
  /// Specifies the HTML div information which is associated with the current table row. 
  /// This information, stored in the Web Settings part, 
  /// is used to associate one or more table rows with a particular HTML div element. 
  /// This property is used when saving an HTML document into the WordprocessingML format 
  /// in order to prevent a loss of all HTML div information, 
  /// so that the document can later be saved back into HTML format and have the stored information replaced, 
  /// since the HTML div can store formatting properties on arbitrary regions. 
  /// </summary>
  public String? DivId { get; set; }

  /// <summary>
  /// Specifies the number of grid columns in the parent table's table grid (§17.4.48; §17.4.47) 
  /// which must be skipped before the contents of this table row (its table cells) are added to the parent table. 
  /// This property is used to specify tables whose leading edge (left for left-to-right tables, right for right-to-left tables) 
  /// does not start at the first grid column (the same shared edge). 
  /// </summary>
  public Int32? GridBefore { get; set; }

  /// <summary>
  /// Specifies the number of grid columns in the parent table's table grid (§17.4.48; §17.4.47) 
  /// which shall be left after the last cell in the table row. 
  /// If this element conflicts with the remaining size of the document grid 
  /// after all table cells in this row have been added to the grid, 
  /// then it shall be ignored.
  /// </summary>
  public Int32? GridAfter { get; set; }

  /// <summary>
  /// Specifies the preferred width for the total number of grid columns before this table row 
  /// as specified in the gridAfter element (§17.4.14). 
  /// This preferred width is used as part of the table layout algorithm specified by the tblLayout element (§17.4.52; §17.4.53) 
  /// - full description of the algorithm in the ST_TblLayout simple type (§17.18.87). 
  /// </summary>
  public TableWidth? WidthBeforeTableRow { get; set; }

  /// <summary>
  /// Specifies the preferred width for the total number of grid columns after this table row 
  /// as specified in the gridAfter element (§17.4.14). 
  /// This preferred width is used as part of the table layout algorithm specified by the tblLayout element (§17.4.52; §17.4.53) 
  /// - full description of the algorithm in the ST_TblLayout simple type (§17.18.87).
  /// </summary>
  public TableWidth? WidthAfterTableRow { get; set; }

  /// <summary>
  /// Specifies the height of the current table row within the current table. 
  /// This height shall be used to determine the resulting height of the table row, 
  /// which can be absolute or relative (depending on its attribute values).
  /// </summary>
  public TableRowHeight? TableRowHeight { get; set; }

  /// <summary>
  /// Specifies that the glyph representing the end character of current table row shall not be displayed in the current document.
  /// </summary>
  public Boolean? Hidden { get; set; }

  /// <summary>
  /// Specifies whether the contents within the current cell shall be rendered on a single page. 
  /// When displaying the contents of a table cell (such as the table cells in ECMA-376), 
  /// it is possible that a page break would fall within the contents of a table cell, 
  /// causing the contents of that cell to be displayed across two different pages. 
  /// If this property is set, then all contents of a table row shall be rendered on the same page 
  /// by moving the start of the current row to the start of a new page if necessary. 
  /// If the contents of this table row cannot fit on a single page, 
  /// then this row shall start on a new page and flow onto multiple pages as necessary. 
  /// </summary>
  public Boolean? CantSplit { get; set; }

  /// <summary>
  /// Specifies that the current table row shall be repeated 
  /// at the top of each new page on which part of this table is displayed. 
  /// This gives this table row the behavior of a 'header' row on each of these pages. 
  /// This property can be applied to any number of rows at the top of the table structure in order to generate multi-row table headers.
  /// </summary>
  public Boolean? TableHeader { get; set; }

  /// <summary>
  /// Specifies the default table cell spacing (the spacing between adjacent cells and the edges of the table) 
  /// for all cells in the parent row. If specified, this element specifies the minimum amount of space 
  /// which shall be left between all cells in the table including the width of the table borders in the calculation. 
  /// It is important to note that row-level cell spacing shall be added inside of the text margins, 
  /// which shall be aligned with the innermost starting edge of the text extents in a cell 
  /// without row-level indentation or cell spacing. Rowlevel cell spacing shall not increase the width of the overall table. 
  /// </summary>
  public TableWidth? TableCellSpacing { get; set; }

  /// <summary>
  /// Specifies the alignment of a single row in the parent table with respect to the text margins in the current section. 
  /// When a table is placed in a WordprocessingML document that does not have the same width as the margins, 
  /// this property is used to determine how a specific row in that table is positioned with respect to those margins. 
  /// The interpretation of property is reversed if the parent table is right to left using the bidiVisual element (§17.4.1). 
  /// </summary>
  public TableRowAlignmentKind? TableJustification { get; set; }

}