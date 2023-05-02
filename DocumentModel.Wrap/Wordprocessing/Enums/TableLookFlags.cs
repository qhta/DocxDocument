namespace DocumentModel.Wordprocessing;

/// <summary>
/// Flags to code ConditionalFormatStyle Val property.
/// Binary values are declared as in OpenXml
/// </summary>
[Flags]
public enum TableLookFlags
{
  /// <summary>
  /// First row conditional formatting shall be applied to the table.
  /// </summary>
  FirstRow = 0x0020,

  /// <summary>
  /// Last row conditional formatting shall be applied to the table.
  /// </summary>
  LastRow = 0x0040,

  /// <summary>
  /// First column conditional formatting shall be applied to the table.
  /// </summary>
  FirstColumn = 0x0080,

  /// <summary>
  /// Last column conditional formatting shall be applied to the table.
  /// </summary>
  LastColumn = 0x0100,

  /// <summary>
  /// Horizontal banding conditional formatting shall not be applied to the table.
  /// </summary>
  HBand = 0x0200,

  /// <summary>
  /// Vertical banding conditional formatting shall not be applied to the table.
  /// </summary>
  VBand = 0x0400,
}
