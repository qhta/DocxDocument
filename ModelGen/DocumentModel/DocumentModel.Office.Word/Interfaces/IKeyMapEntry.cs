namespace DocumentModel.Office.Word;

/// <summary>
/// Defines the KeyMapEntry Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office.Word.IAllocatedCommandKeyboardCustomization))]
[ChildElementInfo(typeof(DocumentModel.Office.Word.IFixedCommandKeyboardCustomization))]
[ChildElementInfo(typeof(DocumentModel.Office.Word.ICharacterInsertion))]
[ChildElementInfo(typeof(DocumentModel.Office.Word.IMacroKeyboardCustomization))]
[ChildElementInfo(typeof(DocumentModel.Office.Word.IWllMacroKeyboardCustomization))]
public interface IKeyMapEntry // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// chmPrimary
  /// </summary>
  public IHexBinaryValue? CharacterMapPrimary { get ; set; }
  
  /// <summary>
  /// chmSecondary
  /// </summary>
  public IHexBinaryValue? CharacterMapSecondary { get ; set; }
  
  /// <summary>
  /// kcmPrimary
  /// </summary>
  public IHexBinaryValue? KeyCodePrimary { get ; set; }
  
  /// <summary>
  /// kcmSecondary
  /// </summary>
  public IHexBinaryValue? KeyCodeSecondary { get ; set; }
  
  /// <summary>
  /// mask
  /// </summary>
  public bool? Mask { get ; set; }
  
  /// <summary>
  /// FixedCommandKeyboardCustomization.
  /// </summary>
  public IFixedCommandKeyboardCustomization? FixedCommandKeyboardCustomization { get ; set; }
  
  /// <summary>
  /// MacroKeyboardCustomization.
  /// </summary>
  public IMacroKeyboardCustomization? MacroKeyboardCustomization { get ; set; }
  
  /// <summary>
  /// AllocatedCommandKeyboardCustomization.
  /// </summary>
  public IAllocatedCommandKeyboardCustomization? AllocatedCommandKeyboardCustomization { get ; set; }
  
  /// <summary>
  /// WllMacroKeyboardCustomization.
  /// </summary>
  public IWllMacroKeyboardCustomization? WllMacroKeyboardCustomization { get ; set; }
  
  /// <summary>
  /// CharacterInsertion.
  /// </summary>
  public ICharacterInsertion? CharacterInsertion { get ; set; }
  
}
