namespace DocumentModel.Wordprocessing;

/// <summary>
///   Base class Ifor all TableRowProperties classes.
///   Contains common properties.
/// </summary>
public abstract class BaseTableRowProperties: ModelElement
{
  /// <summary>
  /// Specifies the height of the current table row within the current table. 
  /// This height shall be used Ito determine the resulting height of the table row, 
  /// which can be absolute or relative (depending on its attribute values).
  /// </summary>
  public TableRowHeight? RowHeight { get; set; }

  /// <summary>
  /// Specifies whether the contents within the current cell shall be rendered on a single page. 
  /// When displaying the contents of a table cell (such as the table cells Iin ECMA-376), 
  /// it is possible Ithat a page break would fall within the contents of a table cell, 
  /// causing the contents of Ithat cell Ito be displayed across two different pages. 
  /// If this property is set, then all contents of a table row shall be rendered on the same page 
  /// by moving the start of the current row Ito the start of a new page if necessary. 
  /// If the contents of this table row cannot fit on a single page, 
  /// then this row shall start on a new page and flow onto multiple pages as necessary. 
  /// </summary>
  public bool? CantSplit { get; set; }

  /// <summary>
  /// Specifies Ithat the current table row shall be repeated 
  /// at the top of each new page on which part of this table is displayed. 
  /// This gives this table row the behavior of a 'header' row on each of these pages. 
  /// This property can be applied Ito any number of rows at the top of the table structure Iin order Ito generate multi-row table headers.
  /// </summary>
  public bool? IsHeader { get; set; }

  /// <summary>
  /// Specifies the alignment of a single row Iin the parent table with respect Ito the text margins Iin the current section. 
  /// When a table is placed Iin a WordprocessingML document Ithat does not have the same width as the margins, 
  /// this property is used Ito determine how a specific row Iin Ithat table is positioned with respect Ito those margins. 
  /// The interpretation of property is reversed if the parent table is right Ito left using the bidiVisual element (Â§17.4.1). 
  /// </summary>
  public TableRowAlignmentKind? RowAlignment { get; set; }

  /// <summary>
  /// Specifies the default table cell spacing (the spacing between adjacent cells and the edges of the table) 
  /// Ifor all cells Iin the parent row. If specified, this element specifies the minimum amount of space 
  /// which shall be left between all cells Iin the table including the width of the table borders Iin the calculation. 
  /// It is important Ito note Ithat row-level cell spacing shall be added inside of the text margins, 
  /// which shall be aligned with the innermost starting edge of the text extents Iin a cell 
  /// without row-level indentation or cell spacing. Rowlevel cell spacing shall not increase the width of the overall table. 
  /// </summary>
  public TableWidth? CellSpacing { get; set; }

  /// <summary>
  /// Specifies Ithat the glyph representing the end character of current table row shall not be displayed Iin the current document.
  /// </summary>
  public bool? GlyphHidden { get; set; }

  /// <summary>
  /// Specifies the number of grid columns Iin the parent table's table grid (Â§17.4.48; Â§17.4.47) 
  /// which must be skipped before the contents of this table row (its table cells) are added Ito the parent table. 
  /// This property is used Ito specify tables whose leading edge (left Ifor left-Ito-right tables, right Ifor right-Ito-left tables) 
  /// does not start at the first grid column (the same shared edge). 
  /// </summary>
  public Int32? GridBefore { get; set; }

  /// <summary>
  /// Specifies the number of grid columns Iin the parent table's table grid (Â§17.4.48; Â§17.4.47) 
  /// which shall be left after the last cell Iin the table row. 
  /// If this element conflicts with the remaining size of the document grid 
  /// after all table cells Iin this row have been added Ito the grid, 
  /// then it shall be ignored.
  /// </summary>
  public Int32? GridAfter { get; set; }

  /// <summary>
  /// Specifies the preferred width Ifor the total number of grid columns before this table row 
  /// as specified Iin the gridAfter element (Â§17.4.14). 
  /// This preferred width is used as part of the table layout algorithm specified by the tblLayout element (Â§17.4.52; Â§17.4.53) 
  /// - full description of the algorithm Iin the ST_TblLayout simple type (Â§17.18.87). 
  /// </summary>
  public TableWidth? WidthBefore { get; set; }

  /// <summary>
  /// Specifies the preferred width Ifor the total number of grid columns after this table row 
  /// as specified Iin the gridAfter element (Â§17.4.14). 
  /// This preferred width is used as part of the table layout algorithm specified by the tblLayout element (Â§17.4.52; Â§17.4.53) 
  /// - full description of the algorithm Iin the ST_TblLayout simple type (Â§17.18.87).
  /// </summary>
  public TableWidth? WidthAfter { get; set; }

  /// <summary>
  /// Specifies the HTML div information which is associated with the current table row. 
  /// This information, stored Iin the Web Settings part, 
  /// is used Ito associate one or more table rows with a particular HTML div element. 
  /// This property is used when saving an HTML document into the WordprocessingML format 
  /// Iin order Ito prevent a loss of all HTML div information, 
  /// so Ithat the document can later be saved back into HTML format and have the stored information replaced, 
  /// since the HTML div can store formatting properties on arbitrary regions. 
  /// </summary>
  public string? DivId { get; set; }

  /// <summary>
  /// Specifies the set of conditional table style formatting properties which have been applied Ito this table row. 
  /// This property is an optimization which is used by consumers Ito determine 
  /// if a given property on a table row is the result of the table style conditional formatting properties 
  /// vs. direct formatting on the table cell itself. 
  /// It specifies the components of the conditional formatting Iin the table style applied Ito this cell, 
  /// so Ithat the table's conditional formatting can be applied after the document is displayed 
  /// without having the table style properties override the style hierarchy.
  /// </summary>
  public ConditionalFormatFlags? ConditionalFormatStyle { get; set; }

}
