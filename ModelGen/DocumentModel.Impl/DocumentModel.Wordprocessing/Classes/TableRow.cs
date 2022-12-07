namespace DocumentModel.Wordprocessing;

/// <summary>
/// Table Row.
/// </summary>
public class TableRowImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.TableRow>, TableRow
{
  /// <summary>
  /// Table-Level Property Exceptions.
  /// </summary>
  public TablePropertyExceptions? TablePropertyExceptions
  {
    get;
    set;
  }
  
  /// <summary>
  /// Table Row Properties.
  /// </summary>
  public TableRowProperties? TableRowProperties
  {
    get;
    set;
  }
  
}
