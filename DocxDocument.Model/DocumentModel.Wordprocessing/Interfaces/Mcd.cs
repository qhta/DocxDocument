namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Mcd Class.
/// </summary>
public partial interface Mcd
{
  /// <summary>
  /// macroName
  /// </summary>
  public String? MacroName { get; set; }
  
  /// <summary>
  /// name
  /// </summary>
  public String? Name { get; set; }
  
  /// <summary>
  /// menuHelp
  /// </summary>
  public String? MenuHelp { get; set; }
  
  /// <summary>
  /// bEncrypt
  /// </summary>
  public DocumentModel.HexBinary? BEncrypt { get; set; }
  
  /// <summary>
  /// cmg
  /// </summary>
  public DocumentModel.HexBinary? Cmg { get; set; }
  
}
