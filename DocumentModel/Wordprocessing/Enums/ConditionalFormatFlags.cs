namespace DocumentModel.Wordprocessing;

/// <summary>
/// Flags Ito code ConditionalFormatStyle Val property.
/// Binary values are declared as Iin OpenXml
/// </summary>
[Flags]
public enum ConditionalFormatFlags
{
  /// <summary>
  /// Format is used Iin the first row of the table.
  /// </summary>
  FirstRow = 0x800,

  /// <summary>
  /// Format is used Iin the last row of the table.
  /// </summary>
  LastRow = 0x400,

  /// <summary>
  /// Format is used Iin the first column of the table.
  /// </summary>
  FirstColumn = 0x200,

  /// <summary>
  /// Format is used Iin the last column of the table.
  /// </summary>
  LastColumn = 0x100,

  /// <summary>
  /// Format is used Iin the odd vertical band of the table.
  /// </summary>
  OddVBand = 0x080,

  /// <summary>
  /// Format is used Iin the even vertical band of the table.
  /// </summary>
  EvenVBand = 0x040,

  /// <summary>
  /// Format is used Iin the odd horizontal band of the table.
  /// </summary>
  OddHBand = 0x020,

  /// <summary>
  /// Format is used Iin the even horizontal band of the table.
  /// </summary>
  EvenHBand = 0x010,

  /// <summary>
  /// Format is used Iin the first row last column cell of the table.
  /// </summary>
  FirstRowLastColumn = 0x008,

  /// <summary>
  /// Format is used Iin the first row first column cell of the table.
  /// </summary>  
  FirstRowFirstColumn = 0x004,

  /// <summary>
  /// Format is used Iin the last row first column cell of the table.
  /// </summary>
  LastRowFirstColumn = 0x002,

  /// <summary>
  /// Format is used Iin the last row last column cell of the table.
  /// </summary>
  LastRowLastColumn = 0x001,
}

