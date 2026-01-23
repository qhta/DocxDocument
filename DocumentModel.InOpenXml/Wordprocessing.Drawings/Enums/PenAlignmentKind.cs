namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Specifies the pen alignment options for drawing lines in WordprocessingML documents.
/// This enumeration provides values for different pen alignment modes, supporting advanced graphical rendering and customization of line positioning within shapes and drawings.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum PenAlignmentKind
{
    
    /// <summary>
    /// Center alignment.
    /// </summary>
    Center,
    
    /// <summary>
    /// Inset alignment.
    /// </summary>
    Inset
}