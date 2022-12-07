namespace DocumentModel.Wordprocessing;

/// <summary>
/// Revision Information for Table-Level Property Exceptions.
/// </summary>
public class TablePropertyExceptionsChangeImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.TablePropertyExceptionsChange>, TablePropertyExceptionsChange
{
  /// <summary>
  /// Previous Table-Level Property Exceptions.
  /// </summary>
  public PreviousTablePropertyExceptions? PreviousTablePropertyExceptions
  {
    get;
    set;
  }
  
}
