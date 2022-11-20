namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the ConflictMode Class.
/// </summary>
public interface IConflictMode // : DocumentFormat.OpenXml.Office2010.Word.OnOffType
{
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public OnOffValues? Val { get ; set; }
  
}
