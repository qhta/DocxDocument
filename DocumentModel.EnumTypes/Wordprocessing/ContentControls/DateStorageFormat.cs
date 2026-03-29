namespace DocumentModel.Wordprocessing;

/// <summary>
/// Indicates how the date for a date content control is stored or retrieved when the date control is bound to an
/// XML node in the document's data store.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdcontentcontroldatestorageformat?view=office-pia` for Office interop details.
/// </remarks>
public enum DateStorageFormat
{
  /// <summary>
  /// Specifies to store or retrieve the date value for a date content control as text.
  /// </summary>
  Text = 0,
  /// <summary>
  /// Specifies to store or retrieve the date value for a date content control as a date in the standard XML Schema
  /// DateTime format.
  /// </summary>
  Date = 1,
  /// <summary>
  /// Specifies to store or retrieve the date value for a date content control as a time in the standard XML Schema
  /// DateTime format.
  /// </summary>
  DateTime = 2
}
