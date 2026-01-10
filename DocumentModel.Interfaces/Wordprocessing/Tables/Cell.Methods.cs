using DocumentFormat.OpenXml.Spreadsheet;

namespace DocumentModel.Wordprocessing;

public partial interface TableCell : CollectionItem
{

    /// <summary>
    /// Merges the cell with the cell to its right.
    /// </summary>
    public void MergeRight();

    /// <summary>
    /// Merges the cell with the cell below it.
    /// </summary>
    public void MergeDown();

    /// <summary>
    /// Splits a merged cell into separate cells.
    /// </summary>
    /// <param name="numRows">Number of rows to split into.</param>
    /// <param name="numColumns">Number of columns to split into.</param>
    public void Split(int numRows, int numColumns);


    /// <summary>
    /// Selects the cell.
    /// </summary>
    public void Select();

    /// <summary>
    /// Deletes the cell from the table.
    /// </summary>
    /// <param name="shiftCells">Whether to shift remaining cells to fill the gap.</param>
    public void Delete(bool shiftCells = true);

    /// <summary>
    /// Sets the width of the cell.
    /// </summary>
    /// <param name="width">The width value.</param>
    /// <param name="rulerkind">The width type (auto, percentage, or absolute).</param>
    public void SetWidth(float width, WidthRuleKind rulerkind);

    /// <summary>
    /// Sets the height of the cell.
    /// </summary>
    /// <param name="height">The height value in points.</param>
    /// <param name="heightRule">The height rule (auto, at least, or exactly).</param>
    public void SetHeight(float height, HeightRuleKind heightRule);

    /// <summary>
    /// Converts the cell to text.
    /// </summary>
    /// <param name="separator">Optional character to use as paragraph separator.</param>
    /// <returns>Range containing the converted text.</returns>
    public Range? ConvertToText(string? separator = null);

    /// <summary>
    /// Applies autofit to the cell based on its content.
    /// </summary>
    public void AutoFit();

}