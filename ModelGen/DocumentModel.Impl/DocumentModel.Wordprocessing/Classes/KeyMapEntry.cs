namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the KeyMapEntry Class.
/// </summary>
public class KeyMapEntryImpl: ModelElement<DocumentFormat.OpenXml.Office.Word.KeyMapEntry>, KeyMapEntry
{
  /// <summary>
  /// FixedCommandKeyboardCustomization.
  /// </summary>
  public FixedCommandKeyboardCustomization? FixedCommandKeyboardCustomization
  {
    get;
    set;
  }
  
  /// <summary>
  /// MacroKeyboardCustomization.
  /// </summary>
  public Boolean? MacroKeyboardCustomization
  {
    get;
    set;
  }
  
  /// <summary>
  /// AllocatedCommandKeyboardCustomization.
  /// </summary>
  public Boolean? AllocatedCommandKeyboardCustomization
  {
    get;
    set;
  }
  
}
