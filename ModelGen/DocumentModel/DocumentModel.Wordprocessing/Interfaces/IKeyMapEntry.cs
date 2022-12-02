namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the KeyMapEntry Class.
/// </summary>
public interface IKeyMapEntry // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// chmPrimary
  /// </summary>
  public DocumentModel.IHexBinaryValue? CharacterMapPrimary { get ; set; }
  
  /// <summary>
  /// chmSecondary
  /// </summary>
  public DocumentModel.IHexBinaryValue? CharacterMapSecondary { get ; set; }
  
  /// <summary>
  /// kcmPrimary
  /// </summary>
  public DocumentModel.IHexBinaryValue? KeyCodePrimary { get ; set; }
  
  /// <summary>
  /// kcmSecondary
  /// </summary>
  public DocumentModel.IHexBinaryValue? KeyCodeSecondary { get ; set; }
  
  /// <summary>
  /// mask
  /// </summary>
  public Boolean? Mask { get ; set; }
  
  /// <summary>
  /// FixedCommandKeyboardCustomization.
  /// </summary>
  public IFixedCommandKeyboardCustomization? FixedCommandKeyboardCustomization { get ; set; }
  
  /// <summary>
  /// MacroKeyboardCustomization.
  /// </summary>
  public IMacroWllType? MacroKeyboardCustomization { get ; set; }
  
  /// <summary>
  /// AllocatedCommandKeyboardCustomization.
  /// </summary>
  public IAcceleratorKeymapType? AllocatedCommandKeyboardCustomization { get ; set; }
  
  /// <summary>
  /// WllMacroKeyboardCustomization.
  /// </summary>
  public IMacroWllType? WllMacroKeyboardCustomization { get ; set; }
  
  /// <summary>
  /// CharacterInsertion.
  /// </summary>
  public DocumentModel.IHexBinaryValue? CharacterInsertion { get ; set; }
  
}
