namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the TextFields Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ITextField))]
public class TextFields: ITextFields
{
  /// <summary>
  /// Count of Fields
  /// </summary>
  public uint? Count
  {
    get;
    set;
  }
  
}
