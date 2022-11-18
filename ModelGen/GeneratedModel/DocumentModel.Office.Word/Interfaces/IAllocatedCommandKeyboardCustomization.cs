namespace DocumentModel.Office.Word;

/// <summary>
/// Defines the AllocatedCommandKeyboardCustomization Class.
/// </summary>
public interface IAllocatedCommandKeyboardCustomization // : DocumentFormat.OpenXml.Office.Word.AcceleratorKeymapType
{
  /// <summary>
  /// acdName
  /// </summary>
  public string? AcceleratorName { get ; set; }
  
}
