namespace DocumentModel.Wordprocessing
{
  /// <summary>
  /// Specifies the date storage format for a content control, corresponding to Microsoft.Office.Interop.Word.WdContentControlDateStorageFormat.
  /// </summary>
  public enum DateStorageFormat
  {
    /// <summary>Store date as date/time value (ISO 8601 format).</summary>
    DateTime = 0,
    /// <summary>Store date as text.</summary>
    Text = 1,
    /// <summary>Store date as date value only (no time).</summary>
    Date = 2
  }
}
