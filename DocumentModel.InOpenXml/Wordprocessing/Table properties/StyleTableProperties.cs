namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents style table properties for a table in a Wordprocessing document.
/// This interface provides properties for row and column band sizes, enabling advanced table styling and formatting options.
/// </summary>
public class StyleTableProperties : BaseTableProperties
{

  /// <summary>
  /// Table style row band size, specifying the number of rows in each band for table styling.
  /// </summary>
  public Int32? TableStyleRowBandSize { get; set; }

  /// <summary>
  /// Table style column band size, specifying the number of columns in each band for table styling.
  /// </summary>
  public Int32? TableStyleColumnBandSize { get; set; }
}