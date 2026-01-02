namespace DocumentModel.Wordprocessing;
/// <summary>
/// Flags to code ConditionalFormatStyle Val property.
/// Binary values are declared as in OpenXml
/// </summary>
[Flags]
public enum ConditionalFormatFlags
{
  /// <summary>
  /// Format is used in the first row of the table.
  /// </summary>
  FirstRow = 0x800,
  /// <summary>
  /// Format is used in the last row of the table.
  /// </summary>
  LastRow = 0x400,
  /// <summary>
  /// Format is used in the first column of the table.
  /// </summary>
  FirstColumn = 0x200,
  /// <summary>
  /// Format is used in the last column of the table.
  /// </summary>
  LastColumn = 0x100,
  /// <summary>
  /// Format is used in the odd vertical band of the table.
  /// </summary>
  OddVBand = 0x080,
  /// <summary>
  /// Format is used in the even vertical band of the table.
  /// </summary>
  EvenVBand = 0x040,
  /// <summary>
  /// Format is used in the odd horizontal band of the table.
  /// </summary>
  OddHBand = 0x020,
  /// <summary>
  /// Format is used in the even horizontal band of the table.
  /// </summary>
  EvenHBand = 0x010,
  /// <summary>
  /// Format is used in the first row last column cell of the table.
  /// </summary>
  FirstRowLastColumn = 0x008,
  /// <summary>
  /// Format is used in the first row first column cell of the table.
  /// </summary>  
  FirstRowFirstColumn = 0x004,
  /// <summary>
  /// Format is used in the last row first column cell of the table.
  /// </summary>
  LastRowFirstColumn = 0x002,
  /// <summary>
  /// Format is used in the last row last column cell of the table.
  /// </summary>
  LastRowLastColumn = 0x001,
}
