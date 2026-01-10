namespace DocumentModel.Wordprocessing.VBA;

/// <summary>
/// Represents a macro data structure (Mcd) for VBA in a Wordprocessing document.
/// This interface provides properties for macro name, display name, menu help text, and encryption-related values, enabling storage and management of supplementary macro information for VBA-enabled documents.
/// </summary>
public interface Mcd : CollectionItem
{
    
    /// <summary>
    /// The name of the macro associated with this data structure.
    /// </summary>
    public string? MacroName { get; set; }
    
    /// <summary>
    /// The display name for the macro or related item.
    /// </summary>
    public string? Name { get; set; }
    
    /// <summary>
    /// The help text displayed in the menu for this macro.
    /// </summary>
    public string? MenuHelp { get; set; }
    
    /// <summary>
    /// The encryption value for the macro, stored as a hexadecimal character.
    /// </summary>
    public HexChar? BEncrypt { get; set; }
    
    /// <summary>
    /// The CMG (Code Management Group) value for the macro, stored as a hexadecimal character.
    /// </summary>
    public HexChar? Cmg { get; set; }
}