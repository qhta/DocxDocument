namespace DocumentModel.Interop.Word;

/// <summary>
/// Indicates how the date for a date content control is stored or retrieved when the date control is bound to an
/// XML node in the document's data store.
/// </summary>
public enum WdContentControlDateStorageFormat
{
  /// <summary>
  /// Specifies to store or retrieve the date value for a date content control as text.
  /// </summary>
  wdContentControlDateStorageText = unchecked((int)0),
  /// <summary>
  /// Specifies to store or retrieve the date value for a date content control as a date in the standard XML Schema
  /// DateTime format. wdContentControlDateStorageDateTime2 Specifies to store or retrieve the date value for a date
  /// content control as a time in the standard XML Schema DateTime format.
  /// </summary>
  wdContentControlDateStorageDate = unchecked((int)1),
  /// <summary>
  /// Indicates how the date for a date content control is stored or retrieved when the date control is bound to an
  /// XML node in the document's data store.
  /// </summary>
  wdContentControlDateStorageDateTime = unchecked((int)2)
}
