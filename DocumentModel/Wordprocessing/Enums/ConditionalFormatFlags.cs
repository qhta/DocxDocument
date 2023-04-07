namespace DocumentModel.Wordprocessing;

/// <summary>
/// Flags to code <see cref="ConditionalFormatStyle"/> Val property.
/// Binary values are declared as in OpenXml
/// </summary>
[Flags]
public enum ConditionalFormatFlags
{
  /// <summary>
  /// Format is used in the first row of the table.
  /// </summary>
  firstRow = 0x800,

  /// <summary>
  /// Format is used in the last row of the table.
  /// </summary>
  lastRow = 0x400,

  /// <summary>
  /// Format is used in the first column of the table.
  /// </summary>
  firstColumn = 0x200,

  /// <summary>
  /// Format is used in the last column of the table.
  /// </summary>
  lastColumn = 0x100,

  /// <summary>
  /// Format is used in the odd vertical band of the table.
  /// </summary>
  oddVBand = 0x080,

  /// <summary>
  /// Format is used in the even vertical band of the table.
  /// </summary>
  evenVBand = 0x040,

  /// <summary>
  /// Format is used in the odd horizontal band of the table.
  /// </summary>
  oddHBand = 0x020,

  /// <summary>
  /// Format is used in the even horizontal band of the table.
  /// </summary>
  evenHBand = 0x010,

  /// <summary>
  /// Format is used in the first row last column cell of the table.
  /// </summary>
  firstRowLastColumn = 0x008,

  /// <summary>
  /// Format is used in the first row first column cell of the table.
  /// </summary>  
  firstRowFirstColumn = 0x004,

  /// <summary>
  /// Format is used in the last row first column cell of the table.
  /// </summary>
  lastRowFirstColumn = 0x002,

  /// <summary>
  /// Format is used in the last row last column cell of the table.
  /// </summary>
  lastRowLastColumn = 0x001,
}
