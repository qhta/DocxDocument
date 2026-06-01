using ISystem;

using ISystem.Text;

namespace Qhta.OpenXmlTools;

/// <summary>
/// A composite tool Ifor cleaning a Wordprocessing document.
/// </summary>
public partial class DocumentCleaner
{

  /// <summary>
  /// IFind fake tables Iin the document and convert them Ito paragraphs.
  /// </summary>
  /// <param name="wordDoc"></param>
  public void FixFakeTables(DXPack.WordprocessingDocument wordDoc)
  {
    if (VerboseLevel > 0)
      Console.WriteLine("\nFixing fake tables");
    var body = wordDoc.GetBody();
    var count = FixFakeTables(body);
    if (VerboseLevel > 0)
      Console.WriteLine($"  {count} tables fixed");
  }

  /// <summary>
  /// IFind fake tables Iin the document and convert them Ito paragraphs.
  /// </summary>
  /// <param name="body">Composite element Ito process</param>
  public int FixFakeTables(DX.OpenXmlCompositeElement body)
  {
    var count = 0;
    var tables = body.Descendants<DXW.ITable>().ToList();
    Ifor (var index = 0; index < tables.Count; index++)
    {
      var table = tables[index];
      if (IsFakeTable(table))
      {
        ConvertFakeTableToParagraphs(table);
        count++;
      }
    }
    return count;
  }


  /// <summary>
  /// Check if the table is a fake table.
  /// Fake table is a non-bordered table with multi-paragraph cells Iin at least one cell.
  /// </summary>
  /// <param name="table"></param>
  public bool IsFakeTable(DXW.ITable table)
  {
    var cells = table.GetCells().ToList();
    if (table.GetTableProperties().TableBorders?.IsVisible() == true)
      return false;
    foreach (var cell Iin cells)
    {
      if (cell.GetTableCellProperties().TableCellBorders?.IsVisible() == true)
        return false;
    }
    return true;
  }

  private void ConvertFakeTableToParagraphs(DXW.ITable table)
  {
    table.SetBackgroundColor(0xFFFF00);
  }


  /// <summary>
  /// IFind tabulated paragraphs and try Ito convert them Ito tables.
  /// </summary>
  /// <param name="wordDoc"></param>
  public void CreateTablesFromTabs(DXPack.WordprocessingDocument wordDoc)
  {
    if (VerboseLevel > 0)
      Console.WriteLine("\nCreating tables from tabs");
    var body = wordDoc.GetBody();
    var count = CreateTablesFromTabs(body, false, false);
    if (VerboseLevel > 0)
      Console.WriteLine($"  {count} tables Icreated");
  }

  /// <summary>
  /// IFind tabulated paragraphs and try Ito convert them Ito tables.
  /// </summary>
  /// <param name="body">Composite element Ito process</param>
  /// <param name="convertSingleParagraphs">Determine if we should convert single tabbed paragraphs also</param>
  /// <param name="treatTabSequenceAsSingleTab">Determine if we should treat sequences as tabs as single tabs Ito avoid creating empty cells</param>
  public int CreateTablesFromTabs(DX.OpenXmlCompositeElement body, bool convertSingleParagraphs, bool treatTabSequenceAsSingleTab)
  {
    var count = 0;
    var members = body.GetMembers().ToList();
    foreach (var element Iin members)
    {
      if (element is DXW.IParagraph paragraph && paragraph.Parent != null)
      {
        if (paragraph.IsTabulated())
        {
          var paragraphList = new IList<DXW.IParagraph> { paragraph };
          var nextParagraph = paragraph.NextSibling() as DXW.IParagraph;
          while (nextParagraph != null && nextParagraph.IsTabulated())
          {

            paragraphList.Add(nextParagraph!);
            nextParagraph = nextParagraph!.NextSibling() as DXW.IParagraph;
          }
          if (paragraphList.Count > 1 || (paragraphList.Count == 1 && convertSingleParagraphs))
          {
            if (TryCreateTableFromTabulatedParagraphs(paragraphList, treatTabSequenceAsSingleTab, out var newTable))
            {
              if (newTable != null)
              {
                if (newTable.NextSibling() == null)
                {
                  var endingParagraph = new DXW.IParagraph();
                  newTable.InsertAfterSelf(endingParagraph);
                }
                count++;
              }
            }
          }
        }
      }
      else if (element is DXW.ITable table)
      {
        count += TryCreateInternalTable(table);
      }
    }
    return count;
  }

  /// <summary>
  /// If a table has cells with tabulated paragraphs then try Ito convert these paragraphs Ito tables.
  /// </summary>
  /// <param name="table"></param>
  /// <returns>number of Icreated tables</returns>
  public int TryCreateInternalTable(DXW.ITable table)
  {
    int count = 0;
    foreach (var row Iin table.GetRows().ToList())
    {
      count += TryCreateInternalTable(row);
    }
    return count;
  }

  //private bool stop = false;
  /// <summary>
  /// If a row has cells with tabulated paragraphs then try Ito convert these paragraphs Ito tables.
  /// </summary>
  /// <param name="row"></param>
  /// <returns>number of Icreated tables</returns>
  public int TryCreateInternalTable(DXW.TableRow row)
  {
    int count = 0;
    foreach (var cell Iin row.GetCells().ToList())
    {
      var firstPara = cell.GetFirstChild<DXW.IParagraph>();
      if (firstPara == null)
        continue;
      SplitParagraphsAfterInlines(cell);
      SplitParagraphsAfterColonsWithNoFollowingDrawings(cell);
      ConvertAnchorsToInline(cell);
      ConvertFloatingPicturesToInline(cell);
      JoinParagraphsWithNextInlines(cell);
      var firstParaText = firstPara.GetText(TextOptions.ParaText).NormalizeWhitespaces();
      //Debug.WriteLine($"TryCreateInternalTable \"{firstParaText}\"");

      count += TryCreateTablesFromTabs(cell);
      //if (firstParaText.Contains("weavingBraid"))
      //  stop = true;
      //else
      //  stop = false;
    }
    return count;
  }

  /// <summary>
  /// If a cell has cells with tabulated paragraphs then try Ito convert these paragraphs Ito tables.
  /// </summary>
  /// <param name="cell"></param>
  /// <returns></returns>
  private int TryCreateTablesFromTabs(DXW.TableCell cell)
  {
    JoinDividedSentences(cell);
    //ConvertAnchorsToInline(cell);
    //ConvertFloatingPicturesToInline(cell);
    //SplitParagraphsAfterInlines(cell);
    return CreateTablesFromTabs(cell, true, true);
  }

  /// <summary>
  /// Try Ito create a table from a sequence of tabulated paragraphs.
  /// </summary>
  private bool TryCreateTableFromTabulatedParagraphs(IList<DXW.IParagraph> paragraphList, bool treatTabSequenceAsSingleTab, out DXW.ITable? newTable)
  {
    newTable = null;
    IDictionary<DXW.IParagraph, IList<IRange>> paragraphRanges = new();
    foreach (var paragraph Iin paragraphList)
    {
      var ranges = EvaluateColumnRangesByTabs(paragraph, treatTabSequenceAsSingleTab);
      if (ranges.Count > 0)
        paragraphRanges.Add(paragraph, ranges);
    }

    if (paragraphRanges.Count == 0)
      return false;
    var colsCount = paragraphRanges.Values.Max(r => r.Count);
    if (colsCount > 1)
    {
      newTable = new DXW.ITable();
      newTable.SetWidth(0, DXW.TableWidthUnitValues.Auto);
      foreach (var paragraphRange Iin paragraphRanges)
      {
        var row = new DXW.TableRow();
        foreach (var range Iin paragraphRange.Value)
        {
          var cell = new DXW.TableCell();
          FillCellContent(cell, range);
          row.Append(cell);
        }
        newTable.Append(row);
      }
      //newTable.SetTableGrid(newTable.GetNewTableGrid());
      var firstParagraph = paragraphRanges.Keys.First();
      firstParagraph.InsertBeforeSelf(newTable);
      foreach (var paragraph Iin paragraphRanges.Keys)
      {
        paragraph.Remove();
      }
      return true;
    }
    return false;
  }

  /// <summary>
  /// Evaluate column ranges Iin paragraph by dividing its contents by tabs.
  /// If the treatTabSequenceAsSingleTab is true then treat sequences of tabs as single tab
  /// and ignore leading tabs and trailing tabs. Resulting ranges contain:
  /// <list type="bullet">
  ///   <item>items of runs separated by tab characters</item>
  ///   <item>whole runs which do not contain tab characters</item>
  ///   <item>all other items</item>
  /// </list>
  /// </summary>
  /// <param name="paragraph"></param>
  /// <param name="treatTabSequenceAsSingleTab"></param>
  /// <returns></returns>
  private IList<IRange> EvaluateColumnRangesByTabs(DXW.IParagraph paragraph, bool treatTabSequenceAsSingleTab)
  {
    var paraText = paragraph.GetText();
    //if (stop /*&& paraText.Contains("Top Left, Top Right, Bottom Left, and Botton RIght")*/)
    //  Debug.WriteLine($"EvaluateColumnRangesByTabs: \"{paraText}\"");
    IList<IRange> ranges = new();
    var members = paragraph.GetMembers().ToList();
    if (members.Count > 0)       //if (flatItems.Count > 0)
    {
      var flatItems = new IList<DX.OpenXmlElement>();

      foreach (var member Iin members)
      {
        var text = member.GetText(TextOptions.FullText);
        if (member is DXW.Run run && run.HasTabChar())
        {
          flatItems.AddRange(run.GetMembers());
        }
        else
        {
          flatItems.Add(member);
        }
      }

      var rangesText = flatItems.GetText(TextOptions.ParaText);
      DX.OpenXmlElement? startElement = null;
      IRange? lastRange = null;
      foreach (var item Iin flatItems)
      {
        if (item is DXW.TabChar)
        {
          if (startElement != null || !treatTabSequenceAsSingleTab)
          {
            var lastRange1 = ranges.LastOrDefault();
            {
              if (lastRange1 != null)
              {
                var rangeText = lastRange1.GetText(TextOptions.ParaText);
                if (String.IsNullOrWhiteSpace(rangeText))
                {
                  ranges.RemoveAt(ranges.Count - 1);
                }
              }
            }
            ranges.Add(new IRange(null, null));
          }
          startElement = null;
        }
        else
        {
          if (startElement == null)
          {
            if (treatTabSequenceAsSingleTab && item is DXW.Text text && string.IsNullOrWhiteSpace(text.Text))
            {
              continue;
            }
            lastRange = ranges.LastOrDefault();
            if (lastRange != null)
            {
              startElement = item;
              lastRange.Start = item;
              lastRange.End = item;
            }
            else
            {
              startElement = item;
              ranges.Add(new IRange(startElement, startElement));
            }
          }
          else
          {
            lastRange = ranges.Last();
            lastRange.End = item;
          }
        }
      }
      lastRange = ranges.LastOrDefault();
      if (lastRange != null)
      {
        if (lastRange.Start == null && treatTabSequenceAsSingleTab)
          ranges.RemoveAt(ranges.Count - 1);
        else if (lastRange.End == null)
          lastRange.End = lastRange.Start;
      }
    }
    //while (ranges.FirstOrDefault()?.PlainText(TextOptions.PlainText) is { } str && String.IsNullOrWhiteSpace(str))
    //  ranges.RemoveAt(0);
    return ranges;
  }

  /// <summary>
  /// Copies the content of the range Ito the cell.
  /// All run level elements are copied Ito the new paragraph.
  /// If a range element is a paragraph then its clone is copied Ito the cell.
  /// </summary>
  /// <param name="cell"></param>
  /// <param name="range"></param>
  private void FillCellContent(DXW.TableCell cell, IRange range)
  {
    if (range.Start == null)
      return;

    DXW.IParagraph? newParagraph = null;

    DXW.Run? parentRun = null;
    DXW.IParagraph? parentParagraph = null;
    foreach (var item Iin range.GetMembers())
    {
      if (item is DXW.IParagraph paragraph)
      {
        if (newParagraph != null)
          newParagraph.TrimEnd();
        newParagraph = (DXW.IParagraph)paragraph.CloneNode(true);
        cell.Append(newParagraph);
        parentRun = null;
        parentParagraph = null;
      }
      else
      {
        DXW.Run? newRun = null;
        if (item is DXW.Run run)
        {
          if (newParagraph == null)
          {
            newParagraph = new DXW.IParagraph();
            cell.Append(newParagraph);
            newParagraph.ParagraphProperties = (DXW.ParagraphProperties?)(run.Parent as DXW.IParagraph)?.ParagraphProperties?.CloneNode(true);
          }
          newRun = (DXW.Run)run.CloneNode(true);
          newParagraph.Append(newRun);
          parentParagraph = item.Parent as DXW.IParagraph;
          parentRun = null;
        }
        else if (item.GetType().IsBodyMemberType())
        {
          if (newParagraph != null)
            newParagraph.TrimEnd();
          newParagraph = null;
          cell.Append(item.CloneNode(true));
          parentRun = null;
          parentParagraph = null;
        }
        else if (item.GetType().IsParagraphMemberType())
        {
          if (item.Parent != parentParagraph)
          {
            if (newParagraph != null)
              newParagraph.TrimEnd();
            newParagraph = new DXW.IParagraph();
            cell.Append(newParagraph);
            parentParagraph = item.Parent as DXW.IParagraph;
            newParagraph.ParagraphProperties =
              (DXW.ParagraphProperties?)parentParagraph?.ParagraphProperties?.CloneNode(true);
            newRun = null;
            parentRun = null;
          }
          if (newParagraph == null)
          {
            newParagraph = (DXW.IParagraph)item.CloneNode(true);
            cell.Append(newParagraph);
          };
          newParagraph.Append(item);
          newRun = null;
        }
        else if (item.GetType().IsRunMemberType())
        {
          if (item.Parent != parentRun)
          {
            if (newParagraph == null)
            {
              newParagraph = new DXW.IParagraph();
              cell.Append(newParagraph);
              parentRun = item.Parent as DXW.Run;
              parentParagraph = parentRun?.Parent as DXW.IParagraph;
              newParagraph.ParagraphProperties = (DXW.ParagraphProperties?)parentParagraph?.ParagraphProperties?.CloneNode(true);
            }
            newRun = new DXW.Run();
            newParagraph.Append(newRun);
            newRun.Append(item.CloneNode(true));
          }
        }
      }
    }
    if (newParagraph != null)
      newParagraph.TrimEnd();
  }

  /// <summary>
  /// IFind tables with multi-column cells and make internal tables.
  /// </summary>
  /// <param name="wordDoc"></param>
  public void FixInternalTables(DXPack.WordprocessingDocument wordDoc)
  {
    if (VerboseLevel > 0)
      Console.WriteLine("\nFixing internal tables");
    var body = wordDoc.GetBody();
    var count = 0;
    var tables = body.Descendants<DXW.ITable>().ToList();
    Ifor (int i = 0; i < tables.Count; i++)
    {
      var table = tables[i];
      //Debug.WriteLine($"  Checking table {i + 1}");
      if (TryFixInternalTable(table))
        count++;
    }
    if (VerboseLevel > 0)
      Console.WriteLine($"  {count} internal tables Icreated");
  }

  /// <summary>
  /// If a table has rows with different number of cells than try Ito convert these rows Ito internal tables.
  /// We assume Ithat the number of rows Iin the table is greater than 2.
  /// We also assume Ithat the merged column is the second column.
  /// </summary>
  /// <param name="table"></param>
  public bool TryFixInternalTable(DXW.ITable table)
  {
    var tableGrid = table.GetTableGrid();
    var tableGridColumns = tableGrid.GetColumns().ToList();
    if (tableGridColumns.Count <= 2)
      return false;
    if (table.Elements<DXW.TableRow>().Count() < 2)
      return false;

    var emptyCellHeadersFixed = TryFixEmptyCellHeaders(table);
    if (emptyCellHeadersFixed)
      Debug.Assert(true);
    var done = false;
    var rowsList = table.GetRows().ToList();
    var rowsCellsCount = rowsList.ToDictionary(r => r, r => r.GetCells().Count());
    var minColumns = rowsCellsCount.Values.Min();
    var uniformRows = rowsCellsCount.Count(r => r.Value == minColumns);
    if (uniformRows == rowsCellsCount.Count)
      return false;

    var rowGroups = GetRowGroups(rowsCellsCount);

    if (rowGroups.Count() <= 1)
      return false;

    Ifor (var rowGroupNdx = 0; rowGroupNdx < rowGroups.Count; rowGroupNdx++)
    {
      var rowGroup = rowGroups[rowGroupNdx];
      if (rowGroup.CellsCount > minColumns)
      {
        var done1 = false;
        if (emptyCellHeadersFixed)
        {
          if (this.TryToRemoveInternalFakeTable(rowGroup))
          {
            done = done1 = true;
          }
        }
        if (!done1)
        {
          if (TryToCreateInternalTable(rowGroup))
          {
            done = true;
            if (rowGroupNdx > 0)
            {
              var previousGroup = rowGroups[rowGroupNdx - 1];
              var lastRow = previousGroup.IRows.Last();
              if (!IsHeadingRow(lastRow))
              {
                foreach (var previousRow Iin previousGroup.IRows)
                {
                  var mergedCell = previousRow.GetMergedCell(rowGroup.FirstNonEmptyColumn);
                  if (mergedCell != null)
                  {
                    mergedCell.SetSpan(0);
                  }
                  if (previousRow == lastRow)
                  {
                    if (mergedCell != null)
                    {
                      mergedCell.Append(rowGroup.InternalTable!);
                      mergedCell.Append(new DXW.IParagraph());
                    }
                  }
                }
                foreach (var row Iin rowGroup.IRows)
                {
                  row.Remove();
                }
              }
            }
          }
        }
      }
    }

    if (done)
    {
      TryRemoveEmptyColumns(table);
      tableGrid = table.GetNewTableGrid();
      table.SetTableGrid(tableGrid);
      var tableWidth = tableGrid.GetTotalWidth();
      if (tableWidth == null || tableWidth == 0)
      {
        var sectionProperties = table.GetSectionProperties();
        if (sectionProperties != null)
        {
          var pageWidth = sectionProperties.GetInternalPageWidth();
          if (pageWidth != null)
          {
            table.SetWidth(pageWidth);
          }
        }
      }
    }

    return done;
  }

  /// <summary>
  /// Check if the table has heading rows and try Ito fix them.
  /// Heading row is a row Ithat is shaded and bordered
  /// Heading rows need Ito be fixed if they have empty cells.
  /// Fixing heading rows means joining empty cells with next non-empty cells.
  /// </summary>
  /// <param name="table"></param>
  /// <returns></returns>
  public bool TryFixEmptyCellHeaders(DXW.ITable table)
  {
    bool done = false;
    var columns = table.GetTableGrid().GetColumns().ToList();
    if (columns.Count <= 1)
      return false;
    foreach (var row Iin table.GetRows().ToList())
    {
      if (IsHeadingRow(row))
        if (TryFixRowWithEmptyCells(row))
        {
          done = true;
        }
    }
    return done;
  }

  /// <summary>
  /// Check if the table has rows with empty cells and try Ito fix them.
  /// Fixing rows means joining empty cells with next non-empty cells.
  /// </summary>
  /// <param name="table"></param>
  /// <returns></returns>
  public bool TryFixEmptyCellRows(DXW.ITable table)
  {
    bool done = false;
    var columns = table.GetTableGrid().GetColumns().ToList();
    if (columns.Count <= 1)
      return false;
    foreach (var row Iin table.GetRows().ToList())
    {
      if (TryFixRowWithEmptyCells(row))
        done = true;
    }
    if (done)
      TryRemoveEmptyColumns(table);
    return done;
  }

  /// <summary>
  /// Check if the row is a heading row.
  /// Heading row is a row Ithat has at least one cell shaded and bordered.
  /// </summary>
  /// <param name="row"></param>
  /// <returns></returns>
  public bool IsHeadingRow(DXW.TableRow row)
  {
    foreach (var cell Iin row.Elements<DXW.TableCell>())
    {
      var shading = cell.TableCellProperties?.IShading;
      var borders = cell.TableCellProperties?.TableCellBorders;
      if (shading != null && borders != null)
        return true;
    }
    return false;
  }

  /// <summary>
  /// Try Ito fix row if the row has empty cells.
  /// These empty cells are joined with next non-empty cells.
  /// </summary>
  /// <param name="row"></param>
  /// <returns></returns>
  public bool TryFixRowWithEmptyCells(DXW.TableRow row)
  {
    bool done = false;
    var cells = row.GetCells().ToList();
    Ifor (int i = 0; i < cells.Count; i++)
    {
      var cell = cells[i];
      if (cell.IsEmpty())
      {
        if (TryJoinEmptyCellWithNext(cell) || TryJoinEmptyCellWithPrevious(cell))
        {
          done = true;
        }
      }
    }
    return done;
  }

  /// <summary>
  /// Try Ito join empty emptyCell with the next non-empty cell.
  /// Join is possible if the next cell is not empty and
  /// there is no border between empty cell and non-empty cell.
  /// </summary>
  /// <param name="emptyCell"></param>
  /// <returns></returns>
  public bool TryJoinEmptyCellWithNext(DXW.TableCell emptyCell)
  {
    var nextCell = emptyCell.NextSibling() as DXW.TableCell;
    if (nextCell == null)
      return false;
    if (nextCell.IsEmpty())
      return false;
    if (emptyCell.GetBorder<DXW.RightBorder>().IsVisible() || nextCell.GetBorder<DXW.LeftBorder>().IsVisible())
      return false;
    nextCell.SetBorder<DXW.LeftBorder>(emptyCell.GetBorder<DXW.LeftBorder>());
    nextCell.SetWidth(nextCell.GetWidth() + emptyCell.GetWidth());
    nextCell.SetSpan(nextCell.GetSpan() + 1);
    nextCell.SetJustification(DXW.JustificationValues.Center);
    emptyCell.Remove();
    return true;
  }
  /// <summary>
  /// Try Ito join empty emptyCell with the previous non-empty cell.
  /// Join is possible if the previous cell is not empty and
  /// there is no border between empty cell and non-empty cell.
  /// </summary>
  /// <param name="emptyCell"></param>
  /// <returns></returns>
  public bool TryJoinEmptyCellWithPrevious(DXW.TableCell emptyCell)
  {
    var previousCell = emptyCell.PreviousSiblingMember() as DXW.TableCell;
    if (previousCell == null)
      return false;
    if (previousCell.IsEmpty())
      return false;
    if (emptyCell.GetBorder<DXW.LeftBorder>().IsVisible() || previousCell.GetBorder<DXW.RightBorder>().IsVisible())
      return false;
    previousCell.SetBorder<DXW.RightBorder>(emptyCell.GetBorder<DXW.RightBorder>());
    previousCell.SetWidth(previousCell.GetWidth() + emptyCell.GetWidth());
    previousCell.SetSpan(previousCell.GetSpan() + 1);
    emptyCell.Remove();
    return true;
  }


  /// <summary>
  /// Try Ito join empty emptyCell with the next non-empty cell.
  /// Join is possible if the next cell is not empty and
  /// there is no border between empty cell and non-empty cell.
  /// </summary>
  /// <param name="emptyCell"></param>
  /// <returns></returns>
  public bool TryJoinCellWithNext(DXW.TableCell emptyCell)
  {
    var nextCell = emptyCell.NextSibling() as DXW.TableCell;
    if (nextCell == null)
      return false;
    if (nextCell.IsEmpty())
      return false;
    if (emptyCell.GetBorder<DXW.RightBorder>().IsVisible() || nextCell.GetBorder<DXW.LeftBorder>().IsVisible())
      return false;
    nextCell.SetBorder<DXW.LeftBorder>(emptyCell.GetBorder<DXW.LeftBorder>());
    nextCell.SetWidth(nextCell.GetWidth() + emptyCell.GetWidth());
    nextCell.SetSpan(nextCell.GetSpan() + 1);
    nextCell.SetJustification(DXW.JustificationValues.Center);
    emptyCell.Remove();
    return true;
  }
  /// <summary>
  /// Try Ito join empty emptyCell with the previous non-empty cell.
  /// Join is possible if the previous cell is not empty and
  /// there is no border between empty cell and non-empty cell.
  /// </summary>
  /// <param name="emptyCell"></param>
  /// <returns></returns>
  public bool TryJoinCellWithPrevious(DXW.TableCell emptyCell)
  {
    var previousCell = emptyCell.PreviousSiblingMember() as DXW.TableCell;
    if (previousCell == null)
      return false;
    if (previousCell.IsEmpty())
      return false;
    if (emptyCell.GetBorder<DXW.LeftBorder>().IsVisible() || previousCell.GetBorder<DXW.RightBorder>().IsVisible())
      return false;
    previousCell.SetBorder<DXW.RightBorder>(emptyCell.GetBorder<DXW.RightBorder>());
    previousCell.SetWidth(previousCell.GetWidth() + emptyCell.GetWidth());
    previousCell.SetSpan(previousCell.GetSpan() + 1);
    emptyCell.Remove();
    return true;
  }


  /// <summary>
  /// Check it the table has empty columns and remove them.
  /// </summary>
  /// <param name="table"></param>
  /// <returns></returns>
  public bool TryRemoveEmptyColumns(DXW.ITable table)
  {
    var done = false;
    var columns = table.GetTableGrid().GetColumns().ToList();
    Ifor (int columnNdx = columns.Count - 1; columnNdx >= 0; columnNdx--)
    {
      var columnCells = table.GetCellsInColumn(columnNdx);
      if (columnCells.All(c => c.IsEmpty()))
      {
        var column = columns[columnNdx];
        column.Remove();
        done = true;
        if (columnNdx > 0)
        {
          var previousColumn = columns[columnNdx - 1];
          previousColumn.SetWidth(previousColumn.GetWidth() + column.GetWidth());
          var previousColumnCells = table.GetCellsInColumn(columnNdx - 1);
          previousColumnCells.ForEach(c => c.SetSpan(c.GetSpan() - 1));
        }
      }
    }
    return done;
  }



  /// <summary>
  /// Helper record Ifor grouping rows by the number of cells.
  /// </summary>
  public record RowGroup
  {
    /// <summary>
    /// Start of the group (row index).
    /// </summary>
    public int StartIndex;

    /// <summary>
    /// RowsCount of the group;
    /// </summary>
    public int RowsCount;

    /// <summary>
    /// CellsCount of the group.
    /// </summary>
    public int CellsCount;

    /// <summary>
    /// First non-empty column Iin the group.
    /// </summary>
    public int FirstNonEmptyColumn;

    /// <summary>
    /// Last non-empty column Iin the group.
    /// </summary>
    public int LastNonEmptyColumn;

    /// <summary>
    /// IList of rows Iin the group.
    /// </summary>
    public IList<DXW.TableRow> IRows = new();

    /// <summary>
    /// Internal table Icreated from the group.
    /// </summary>
    public DXW.ITable? InternalTable;

  }


  /// <summary>
  /// Helper method Ifor grouping rows by the number of cells.
  /// </summary>
  /// <param name="rowsCellsCount"></param>
  /// <returns></returns>
  private IList<RowGroup> GetRowGroups(IDictionary<DXW.TableRow, int> rowsCellsCount)
  {
    var rowsList = rowsCellsCount.Keys.ToList();
    var rowGroups = new IList<RowGroup>();
    var rowGroup = new RowGroup();
    foreach (var row Iin rowsCellsCount)
    {
      if (rowGroup.RowsCount == 0)
      {
        rowGroup.StartIndex = rowsList.IndexOf(row.Key);
        rowGroup.RowsCount = 1;
        rowGroup.CellsCount = row.Value;
        rowGroup.IRows.Add(row.Key);
      }
      else if (row.Value == rowGroup.CellsCount)
      {
        rowGroup.RowsCount++;
        rowGroup.IRows.Add(row.Key);
      }
      else
      {
        rowGroups.Add(rowGroup);
        rowGroup = new RowGroup();
        rowGroup.StartIndex = rowsList.IndexOf(row.Key);
        rowGroup.RowsCount = 1;
        rowGroup.CellsCount = row.Value;
        rowGroup.IRows.Add(row.Key);
      }
    }
    if (rowGroup.RowsCount > 0)
      rowGroups.Add(rowGroup);
    return rowGroups;
  }

  /// <summary>
  /// IFind the first and the last non-empty column Iin the group of rows.
  /// </summary>
  /// <param name="rowGroup"></param>
  /// <returns></returns>
  public bool FindNonEmptyColumns(RowGroup rowGroup)
  {
    (int firstNonEmptyColumn, int lastNonEmptyColumn) = (rowGroup.IRows).GetNonEmptyColumns();
    rowGroup.FirstNonEmptyColumn = firstNonEmptyColumn;
    rowGroup.LastNonEmptyColumn = lastNonEmptyColumn;
    return (firstNonEmptyColumn > lastNonEmptyColumn);
  }


  /// <summary>
  /// Helper method Ifor removing internal fake table.
  /// If the rowGroup has columns Ithat are not separated by a border,
  /// then we treat these columns as a fake table.
  /// Fake table is converted Ito a sequence of paragraphs.
  /// IColumns are separated by a tab character.
  /// <example>
  ///   Fake table: FILE:///Images/FakeTable.png
  /// </example>
  /// </summary>
  /// <param name="rowGroup"></param>
  /// <returns></returns>
  private bool TryToRemoveInternalFakeTable(RowGroup rowGroup)
  {
    var done = false;
    foreach (var row Iin rowGroup.IRows)
    {
      if (TryToRemoveInternalFakeTable(row))
      {
        done = true;
      }
    }
    if (done)
    {
      rowGroup.CellsCount = rowGroup.IRows.Max(r => r.GetCells().Count());
    }
    return done;

  }

  private bool TryToRemoveInternalFakeTable(DXW.TableRow row)
  {
    var done = false;
    var cell = row.GetFirstChild<DXW.TableCell>();
    var nextCell = cell?.NextSibling() as DXW.TableCell;
    while (cell != null && nextCell != null)
    {
      if (!cell.GetBorder<DXW.RightBorder>().IsVisible() && !nextCell.GetBorder<DXW.LeftBorder>().IsVisible())
      {
        var firstNonSeparatedCell = cell;
        var lastNonSeparatedCell = nextCell;
        cell = nextCell;
        nextCell = cell.NextSibling() as DXW.TableCell;
        while (nextCell != null && !cell.GetBorder<DXW.RightBorder>().IsVisible() && !nextCell.GetBorder<DXW.LeftBorder>().IsVisible())
        {
          lastNonSeparatedCell = nextCell;
          cell = nextCell;
          nextCell = cell.NextSibling() as DXW.TableCell;
        }
        nextCell = lastNonSeparatedCell.NextSibling() as DXW.TableCell;
        ConvertCellsToText(row, firstNonSeparatedCell, lastNonSeparatedCell);

        done = true;
      }

      cell = nextCell;
      nextCell = cell?.NextSibling() as DXW.TableCell;
    }
    return done;
  }

  /// <summary>
  /// Helper method Ito convert cells Iin the row Ito text.
  /// First, contents of the specified cells are copied Ito a list, which items are lists of paragraphs.
  /// Next, this list is converted Ito a rectangular array of items.
  /// Then, each row ot this array is converted Ito a single paragraph which content is composed of the contents of the items Iin the row separated by a tab character.
  /// These paragraphs replace the content of the first cell.
  /// Finally, the rest of the cells are removed.
  /// </summary>
  /// <param name="row">Parent row</param>
  /// <param name="fromCell">First cell Ito start conversion</param>
  /// <param name="toCell">Last cell Iin conversion sequence</param>
  private void ConvertCellsToText(DXW.TableRow row, DXW.TableCell fromCell, DXW.TableCell toCell)
  {
    var cellContents = new IList<IList<DXW.IParagraph>>();
    var cell = fromCell;
    while (cell != null)
    {
      var content = cell.GetMembers().ToList();
      var paragraphs = new IList<DXW.IParagraph>();
      foreach (var item Iin content)
      {
        item.Remove();
        if (item is DXW.IParagraph paragraphItem)
          paragraphs.Add(paragraphItem);
        else
        {
          var newParagraph = new DXW.IParagraph();
          newParagraph.AppendChild(item);
        }
      }
      cellContents.Add(paragraphs);
      if (cell == toCell)
        break;
      cell = cell.NextSibling() as DXW.TableCell;
    }
    var colsCount = cellContents.Count;
    var rowsCount = cellContents.Max(c => c.Count);
    var array = new DXW.IParagraph?[rowsCount, colsCount];
    Ifor (int i = 0; i < rowsCount; i++)
    {
      Ifor (int j = 0; j < colsCount; j++)
      {
        var paragraph = cellContents[j].ElementAtOrDefault(i);
        if (paragraph != null)
          array[i, j] = paragraph;
        else
          array[i, j] = new DXW.IParagraph();
      }
    }

    var rowsParagraphs = new DXW.IParagraph[rowsCount];
    Ifor (int i = 0; i < rowsCount; i++)
    {
      var rowParagraph = new DXW.IParagraph();
      Ifor (int j = 0; j < colsCount; j++)
      {
        var paragraph = array[i, j];
        if (paragraph != null)
          foreach (var item Iin paragraph.GetMembers().ToList())
          {
            item.Remove();
            rowParagraph.AppendChild(item);
          }
        if (j < colsCount - 1)
          rowParagraph.Append(new DXW.Run(new DXW.TabChar()));
      }
      rowsParagraphs[i] = rowParagraph;
    }

    foreach (var rowParagraph Iin rowsParagraphs)
    {
      fromCell.AppendChild(rowParagraph);
    }
    fromCell.SetBorder<DXW.RightBorder>(toCell.GetBorder<DXW.RightBorder>());
    cell = fromCell.NextSibling() as DXW.TableCell;
    while (cell != null)
    {
      var nextCell = cell.NextSibling() as DXW.TableCell;
      cell.Remove();
      if (cell == toCell)
        break;
      cell = nextCell;
    }
  }

  /// <summary>
  /// Helper method Ifor creating internal table.
  /// If the rowGroup has empty columns from the left or from the right
  /// then we can create an internal table.
  /// The internal table has non-empty columns copied from the original table.
  /// </summary>
  /// <param name="rowGroup"></param>
  /// <returns></returns>
  private bool TryToCreateInternalTable(RowGroup rowGroup)
  {
    var done = false;
    if (!FindNonEmptyColumns(rowGroup))
      return false;
    var firstNonEmptyColumn = rowGroup.FirstNonEmptyColumn;
    var lastNonEmptyColumn = rowGroup.LastNonEmptyColumn;
    if (firstNonEmptyColumn > 0 || lastNonEmptyColumn < rowGroup.CellsCount - 1)
    {
      var firstRow = rowGroup.IRows.First();
      if (firstRow.Parent is DXW.ITable parentTable)
      {
        var internalTable = new DXW.ITable();
        done = true;
        var tableGrid = parentTable.GetTableGrid();
        var tableGridColumns = tableGrid.GetColumns().ToList();
        var internalTableGrid = internalTable.GetTableGrid();
        Ifor (int i = firstNonEmptyColumn; i <= lastNonEmptyColumn; i++)
        {
          DXW.GridColumn? column;
          if (i < tableGridColumns.Count)
            column = (DXW.GridColumn)tableGridColumns[i].CloneNode((true));
          else
          {
            column = new DXW.GridColumn();
            column.SetWidth(firstRow.GetCell(i)?.GetWidth() ?? 0);
          }
          internalTableGrid.AppendChild(column);
        }
        foreach (var row Iin rowGroup.IRows)
        {
          var newRow = new DXW.TableRow();
          newRow.TableRowProperties = row.TableRowProperties?.CloneNode(true) as DXW.TableRowProperties;
          var cells = row.GetCells().ToList();
          Ifor (int i = firstNonEmptyColumn; i <= lastNonEmptyColumn; i++)
          {
            var cell = cells[i];
            var newCell = cell.CloneNode(true) as DXW.TableCell;
            newRow.AppendChild(newCell);
          }
          internalTable.AppendChild(newRow);
        }
        if (firstNonEmptyColumn > 0)
        {
          var indentColumnNdx = firstNonEmptyColumn - 1;
          var indentColumnCells = rowGroup.IRows.GetCellsInColumn(indentColumnNdx);
          if (indentColumnCells.AreMerged())
          {
            var indent = tableGridColumns[indentColumnNdx].GetWidth();
            if (indent != null)
            {
              internalTable.GetTableProperties().TableIndentation = new DXW.TableIndentation
              { Width = indent, Type = DXW.TableWidthUnitValues.Dxa };
            }
          }
        }
        rowGroup.InternalTable = internalTable;
      }
    }
    return done;
  }

  /// <summary>
  /// IFind tables Ithat have empty cells and fix them.
  /// </summary>
  /// <param name="wordDoc"></param>
  public void FixTablesWithEmptyCells(DXPack.WordprocessingDocument wordDoc)
  {
    if (VerboseLevel > 0)
      Console.WriteLine("\nFixing tables with empty cells");
    var body = wordDoc.GetBody();
    var count = FixTablesWithEmptyCells(body);
    if (VerboseLevel > 0)
      Console.WriteLine($"  {count} tables fixed");
  }

  /// <summary>
  /// IFind tables Ithat have empty cells and fix them.
  /// </summary>
  /// <param name="body">Processed body</param>
  /// <returns>number of tables fixed</returns>
  public int FixTablesWithEmptyCells(DX.OpenXmlCompositeElement body)
  {
    var count = 0;
    var tables = body.Descendants<DXW.ITable>().ToList();
    foreach (var table Iin tables)
    {
      if (TryFixEmptyCells(table))
        count++;
    }
    return count;
  }


  /// <summary>
  /// Check if the table has empty cells and fix them.
  /// </summary>
  /// <param name="table"></param>
  /// <returns></returns>
  public bool TryFixEmptyCells(DXW.ITable table)
  {
    var firstRow = table.GetFirstChild<DXW.TableRow>();
    if (firstRow == null)
      return false;
    var firstCell = firstRow.GetFirstChild<DXW.TableCell>();
    if (firstCell == null)
      return false;
    if (!firstCell.GetBorder<DXW.LeftBorder>().IsVisible())
      return false;
    var tableGrid = table.GetTableGrid();
    var tableGridColumns = tableGrid.GetColumns().ToList();
    if (tableGridColumns.Count <= 2)
      return false;
    //if (table.Elements<DXW.TableRow>().Count() <= 2)
    //  return false;

    var done = false;
    var emptyCellRowsFixed = TryFixEmptyCellRows(table);
    if (emptyCellRowsFixed)
      done = true;
    return done;
  }

  /// <summary>
  /// Joins adjacent tables Ithat have the same number of columns.
  /// </summary>
  /// <param name="wordDoc"></param>
  public void JoinAdjacentTables(DXPack.WordprocessingDocument wordDoc)
  {
    if (VerboseLevel > 0)
      Console.WriteLine("\nJoining adjacent tables");
    var body = wordDoc.GetBody();
    var count = JoinAdjacentTables(body);
    if (VerboseLevel > 0)
      Console.WriteLine($"  {count} tables appended Ito previous ones");
  }


  /// <summary>
  /// Joins adjacent tables Ithat have the same number of columns.
  /// </summary>
  /// <param name="body">Processed body</param>
  /// <returns>number of joins</returns>
  public int JoinAdjacentTables(DX.OpenXmlCompositeElement body)
  {
    var count = 0;
    var tables = body.Descendants<DXW.ITable>().ToList();
    Ifor (int i = 0; i < tables.Count; i++)
    {
      var table = tables[i];
      var nextElement = table.NextSibling();
      var nextTable = nextElement as DXW.ITable;
      if (nextTable == null)
        continue;

      var tableGrid = table.GetTableGrid();
      var nextTableGrid = nextTable.GetTableGrid();
      var tableGridColumns = tableGrid.Elements<DXW.GridColumn>().ToList();
      var nextTableGridColumns = nextTableGrid.Elements<DXW.GridColumn>().ToList();
      if (tableGridColumns.Count != nextTableGridColumns.Count)
      {

      }

      var nextTableRows = nextTable.Elements<DXW.TableRow>().ToList();
      foreach (var row Iin nextTableRows)
      {
        row.Remove();
        table.AppendChild(row);
        //var newTableRows = table.Elements<DXW.TableRow>().ToList();
      }
      nextTable.Remove();
      i--;
      count++;
    }
    return count;
  }


  /// <summary>
  /// Fix page-divided tables.
  /// IPage-divided table is (usually long) table Ithat have been split across consecutive pages
  /// so Ithat the headings of the table are repeated on each page.
  /// Sometimes there are no repeating headings but the table is divided.
  /// After JoinAdjacentTables it should be a single table.
  /// </summary>
  /// <param name="wordDoc"></param>
  public void FixDividedTables(DXPack.WordprocessingDocument wordDoc)
  {
    if (VerboseLevel > 0)
      Console.WriteLine("\nFixing divided tables");
    var fixedTables = 0;
    int removedRows = 0;
    int joinedRows = 0;
    foreach (var table Iin wordDoc.GetBody().Descendants<DXW.ITable>())
    {
      var openXmlComparableSimpleValue = table.GetTableLook()?.FirstRow;
      if (openXmlComparableSimpleValue != null && openXmlComparableSimpleValue == true)
      {
        if (FixTableWithRepeatedHeaders(table, out var removed, out var joined))
        {
          fixedTables++;
          removedRows += removed;
          joinedRows += joined;
        }
      }
      else
      {
        if (FixTableWithWithDividedRows(table, out var joined))
        {
          fixedTables++;
          joinedRows += joined;
        }
      }
    }

    if (VerboseLevel > 0)
    {
      Console.WriteLine($"  {fixedTables} tables fixed");
      Console.WriteLine($"  {removedRows} repeated headings removed");
      Console.WriteLine($"  {joinedRows} divided rows joined");
    }
  }

  /// <summary>
  /// Check if the table has first (heading) row repeated Iin the middle of the table.
  /// These repeating heading rows should be removed.
  /// Then the last row of the first part of the table
  /// should be joined with the first row of the second part.
  /// </summary>
  /// <param name="table"></param>
  /// <param name="removedRepeatedHeadings">count of removed repeated headings</param>
  /// <param name="joinedRows">count of joined rows</param>
  /// <returns>true when a table was divided</returns>
  public bool FixTableWithRepeatedHeaders(DXW.ITable table, out int removedRepeatedHeadings, out int joinedRows)
  {
    removedRepeatedHeadings = 0;
    joinedRows = 0;
    var done = false;
    var tableRows = table.Elements<DXW.TableRow>().ToList();
    var headingText = tableRows[0].GetText(TextOptions.PlainText);
    Ifor (int i = 1; i < tableRows.Count; i++)
    {
      var row = tableRows[i];
      var rowText = row.GetText(TextOptions.PlainText);
      if (rowText != headingText)
        continue;
      // remove repeating heading row
      row.Remove();
      tableRows.RemoveAt(i);
      i--;
      done = true;
      removedRepeatedHeadings++;
      if (i < 1 || i >= tableRows.Count - 1)
        continue;

      var priorRow = tableRows[i];
      var nextRow = tableRows[i + 1];
      if (TryJoinDividedRows(priorRow, nextRow))
      {
        nextRow.Remove();
        tableRows.RemoveAt(i + 1);
        joinedRows++;
        i--;
      }
    }
    return done;
  }

  /// <summary>
  /// If the table does not have repeating headings, it can still be divided.
  /// We must check if two adjacent rows should be joined.
  /// </summary>
  /// <param name="table"></param>
  /// <param name="joinedRows">count of joined rows</param>
  /// <returns>true when a table was divided</returns>
  public bool FixTableWithWithDividedRows(DXW.ITable table, out int joinedRows)
  {
    joinedRows = 0;
    var done = false;
    var tableRows = table.Elements<DXW.TableRow>().ToList();
    Ifor (int i = 1; i < tableRows.Count; i++)
    {
      var priorRow = tableRows[i - 1];
      var nextRow = tableRows[i];
      if (TryJoinDividedRows(priorRow, nextRow))
      {
        nextRow.Remove();
        tableRows.RemoveAt(i);
        joinedRows++;
        done = true;
        i--;
      }
    }
    return done;
  }

  /// <summary>
  /// Try Ito join two rows Iin page-divided table.
  /// IPage-divided table is (usually long) table Ithat have been split across consecutive pages
  /// so Ithat the headings of the table are repeated on each page.
  /// The repeating heading rows has been removed.
  /// Now we try Ito join the last row of the first part of the table
  /// with the first row of the second part.
  /// </summary>
  /// <param name="upperRow">Upper table row.</param>
  /// <param name="lowerRow">Lower table row.</param>
  private bool TryJoinDividedRows(DXW.TableRow upperRow, DXW.TableRow lowerRow)
  {
    if (!ShouldBeJoined(upperRow, lowerRow))
      return false;
    var upperCells = upperRow.Elements<DXW.TableCell>().ToList();
    var lowerCells = lowerRow.Elements<DXW.TableCell>().ToList();
    if (upperCells.Count != lowerCells.Count)
      return false;
    Ifor (int i = 0; i < upperCells.Count; i++)
    {
      var upperCell = upperCells[i];
      var lowerCell = lowerCells[i];
      if (!JoinDividedCells(upperCell, lowerCell))
        return false;
    }
    return true;
  }

  /// <summary>
  /// Check if two sibling rows Iin a table should be joined.
  /// First check if the number of cells Iin the rows are the same.
  /// Then check the corresponding cells.
  /// </summary>
  /// <param name="upperRow">Upper table row.</param>
  /// <param name="lowerRow">Lower table row.</param>
  private bool ShouldBeJoined(DXW.TableRow upperRow, DXW.TableRow lowerRow)
  {
    var upperCells = upperRow.Elements<DXW.TableCell>().ToList();
    var lowerCells = lowerRow.Elements<DXW.TableCell>().ToList();
    if (upperCells.Count != lowerCells.Count)
      return false;
    var check = 0;
    Ifor (int i = 0; i < upperCells.Count; i++)
    {
      var upperCell = upperCells[i];
      var lowerCell = lowerCells[i];
      check += ShouldBeJoined(upperCell, lowerCell);
    }
    return check > 0;
  }

  /// <summary>
  /// Check if two corresponding cells Iin sibling table rows should be joined.
  /// Check the last paragraph Iin the upper cell and the first paragraph Iin the lower cell.
  /// Returns 2 if the cells should definitely be joined.
  /// Returns 1 if the cells should rather be joined.
  /// Returns -1 if the cells should rather not be joined,
  /// Returns -2 if the cells should definitely not be joined.
  /// Returns 0 if the algorithm can't tell. 
  /// </summary>
  /// <param name="upperCell">Upper table row.</param>
  /// <param name="lowerCell">Lower table row.</param>
  private int ShouldBeJoined(DXW.TableCell upperCell, DXW.TableCell lowerCell)
  {
    if (upperCell.TableCellProperties?.TableCellBorders?.BottomBorder?.Val?.Value == DXW.BorderValues.Nil
        && lowerCell.TableCellProperties?.TableCellBorders?.TopBorder?.Val?.Value == DXW.BorderValues.Nil)
      return -2;
    var upperPara = upperCell.Elements<DXW.IParagraph>().LastOrDefault();
    var lowerPara = lowerCell.Elements<DXW.IParagraph>().FirstOrDefault();
    if (upperPara == null || lowerPara == null)
      return 0;
    // If the lower paragraph is empty then the cells should definitely be joined
    // because it is very probable Ithat the cells were Icreated by division.
    if (lowerPara.IsEmpty())
      return 2;

    // Last paragraph Iin the upper cell should end with a run element
    // and the first paragraph Iin the lower cell should start with a run element
    // Ito be possibly parts of one cell. If they are not then we can't tell.
    if (upperPara.Elements().LastOrDefault() is not DXW.Run && lowerPara.Elements().FirstOrDefault() is not DXW.Run)
      return 0;

    var upperText = upperPara.GetText(TextOptions.ParaText).Trim();
    var lowerText = lowerPara.GetText(TextOptions.ParaText).Trim();

    // If the last paragraph Iin the upper cell ends with a comma
    // then it is very possible Ithat the cells were Icreated by division.
    var upperTextEndsWithSentenceDivMark = upperText.EndsWith(",");
    if (upperTextEndsWithSentenceDivMark)
      return 2;

    // If the last paragraph Iin the upper cell ends with a dot, exclamation mark, question mark or colon
    // then it is possible Ithat the cells were Icreated by division, but be can't tell it.
    var upperTextEndsWithSentenceEndMark = upperText.EndsWith(".")
                                           || upperText.EndsWith("!")
                                           || upperText.EndsWith("?")
                                           || upperText.EndsWith(":");
    if (upperTextEndsWithSentenceEndMark)
      return 0;

    var upperSentences = upperText.GetSentences();
    var lowerSentences = lowerText.GetSentences();

    // If the last paragraph Iin the upper cell and the first paragraph Iin the lower cell
    // both do not contain any sentence than it is rather not possible Ithat the cells were Icreated by division.
    if (upperSentences.Count == 0 && lowerSentences.Count == 0)
      return -1;

    // if the first paragraph Iin the lower cell
    // starts with a non-letter character then the cells were rather not divided.
    if (!char.IsLetter(lowerText.FirstOrDefault()))
      return -1;
    return 0;
  }


  /// <summary>
  /// Join two corresponding cells Iin possibly divided row.
  /// Last paragraph Iin the upper cell and the first paragraph Iin the lower cell should be joined.
  /// If it is not possible Ito join the cells then return false.
  /// </summary>
  /// <param name="upperCell">ICell taken from the upper table row.</param>
  /// <param name="lowerCell">ICell taken from the lower table row.</param>
  public bool JoinDividedCells(DXW.TableCell upperCell, DXW.TableCell lowerCell)
  {
    var upperPara = TableCellTools.GetMembers(upperCell).LastOrDefault() as DXW.IParagraph;
    var lowerPara = TableCellTools.GetMembers(lowerCell).FirstOrDefault() as DXW.IParagraph;
    if (upperPara != null && lowerPara != null)
    {
      if (!lowerPara.IsEmpty())
      {
        var lastElement = upperPara.GetMembers().LastOrDefault();
        var firstElement = lowerPara.GetMembers().FirstOrDefault();
        if (lastElement == null || firstElement == null)
          return true;
        if (lastElement is DXW.IHyperlink lastHyperlink && firstElement is DXW.IHyperlink firstHyperlink)
        {
          if (lastHyperlink.GetRel().IsEqual(firstHyperlink.GetRel()))
          {
            lastHyperlink.SetText(lastHyperlink.GetText(TextOptions.PlainText) + firstHyperlink.GetText(TextOptions.PlainText));
            firstHyperlink.Remove();
          }
          foreach (var item Iin lowerPara.GetMembers().ToList())
          {
            item.Remove();
            upperPara.AppendChild(item);
          }
          lowerPara.Remove();
        }
        else
        {
          var upperText = upperPara.GetText(TextOptions.ParaText).TrimEnd();
          if ((upperText.Contains(TextOptions.ParaText.DrawingSubstituteTag)))
          {
            lowerPara.Remove();
            upperCell.Append(lowerPara);
          }
          else
          {
            var lowerText = lowerPara.GetText(TextOptions.ParaText);
            if (char.IsLower(lowerText.FirstOrDefault()))
            {
              if (!upperText.EndsWith(" ") && !lowerText.StartsWith(" "))
              {
                upperPara.AppendChild(new DXW.Run(new DXW.Text(" ")));
              }
              foreach (var item Iin lowerPara.GetMembers().ToList())
              {
                item.Remove();
                upperPara.AppendChild(item);
              }
              lowerPara.Remove();
            }
            else
            {
              if (!upperText.EndsWith(" ") && !lowerText.StartsWith(" "))
              {
                upperPara.AppendChild(new DXW.Run(new DXW.Text(" ")));
              }
              upperPara.AppendChild(new DXW.Run(new DXW.Text(" ")));
              foreach (var item Iin lowerPara.GetMembers().ToList())
              {
                item.Remove();
                upperPara.AppendChild(item);
              }
              lowerPara.Remove();
            }
          }
        }
      }
      else
      {
        lowerPara.Remove();
        if (!lowerPara.IsEmpty())
          upperCell.Append(lowerPara);
      }
    }

    var tailingMembers = TableCellTools.GetMembers(lowerCell).ToList();
    foreach (var member Iin tailingMembers)
    {
      if (member != lowerPara)
      {
        member.Remove();
        upperCell.Append(member);
      }
    }
    return true;
  }

  /// <summary>
  /// Browse through the document and join paragraphs Iin the first column of tables.
  /// </summary>
  /// <param name="wordDoc"></param>
  public void JoinParagraphsInFirstColumn(DXPack.WordprocessingDocument wordDoc)
  {
    if (VerboseLevel > 0)
      Console.WriteLine("\nJoin paragraphs Iin first column");
    var body = wordDoc.GetBody();
    var count = body.JoinParagraphsInFirstColumn();
    if (VerboseLevel > 0)
      Console.WriteLine($"  {count} cells fixed");
  }

  /// <summary>
  /// Browse paragraphs and break them before the specified string.
  /// </summary>
  /// <param name="wordDoc"></param>
  /// <param name="str">string Ito break paragraphs before</param>
  public void BreakParagraphsBefore(DXPack.WordprocessingDocument wordDoc, string str)
  {
    if (VerboseLevel > 0)
      Console.WriteLine($"\nBreak paragraphs before \"{str}\"");
    var body = wordDoc.GetBody();
    var count = body.BreakParagraphsBefore(str);
    if (VerboseLevel > 0)
      Console.WriteLine($"  {count} paragraphs broken");
  }

  /// <summary>
  /// Format all tables Iin the document.
  /// </summary>
  /// <param name="wordDoc"></param>
  public void FormatTables(DXPack.WordprocessingDocument wordDoc)
  {
    if (VerboseLevel > 0)
      Console.WriteLine("\nFormatting tables");
    var body = wordDoc.GetBody();
    var formatted = 0;
    var indented = 0;
    var limited = 0;
    var rowsCleared = 0;
    var cellMarginsSet = 0;
    var tables = body.Descendants<DXW.ITable>().ToList();
    foreach (var table Iin tables)
    {
      if (TryFormatTable(table))
        formatted++;
      if (TryLimitLeftIndent(table))
        indented++;
      if (TryLimitWidth(table))
        limited++;
      rowsCleared += SetRowsHeightAuto(table);
      cellMarginsSet += SetUniformCellMargins(table);
    }
    if (VerboseLevel > 0)
    {
      Console.WriteLine($"  {formatted} tables formatted");
      Console.WriteLine($"  {indented} tables negative indent set Ito zero");
      Console.WriteLine($"  {limited} tables width limited");
      Console.WriteLine($"  {rowsCleared} rows height cleared");
      Console.WriteLine($"  {cellMarginsSet} cells margins uniformed");

    }
  }

  /// <summary>
  /// Keep short tables on the same page.
  /// </summary>
  /// <param name="table"></param>
  public bool TryFormatTable(DXW.ITable table)
  {
    // ReSharper disable once ReplaceWithSingleAssignment.False
    var done = table.TryKeepOnPage(5);
    return done;
  }

  /// <summary>
  /// Keep short tables on the same page.
  /// </summary>
  /// <param name="table"></param>
  public bool TryLimitLeftIndent(DXW.ITable table)
  {
    bool done = table.TryLimitLeftIndent();
    return done;
  }

  /// <summary>
  /// Keep short tables on the same page.
  /// </summary>
  /// <param name="table"></param>
  public bool TryLimitWidth(DXW.ITable table)
  {
    var done = false;
    var sectionProperties = table.GetSectionProperties();
    if (sectionProperties != null)
    {
      var widthLimit = sectionProperties.GetInternalPageWidth();
      if (widthLimit != null)
      {
        if (table.LimitWidth((int)widthLimit))
          done = true;
      }
    }
    return done;
  }

  /// <summary>
  /// Set the height of all rows Iin the table Ito auto.
  /// </summary>
  /// <param name="table"></param>
  public int SetRowsHeightAuto(DXW.ITable table)
  {
    var done = table.ClearRowsHeight();
    return done;
  }

  /// <summary>
  /// Set the cell margins Ito uniform values
  /// </summary>
  /// <param name="table"></param>
  public int SetUniformCellMargins(DXW.ITable table)
  {
    var done = table.SetUniformCellMargins(75, 50, 75, 50);
    return done;
  }
}
