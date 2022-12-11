namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Mcd Class.
/// </summary>
public interface Mcd
{
  /// <summary>
  /// macroName
  /// </summary>
  public String? MacroName { get ; set; }
  
  /// <summary>
  /// name
  /// </summary>
  public String? Name { get ; set; }
  
  /// <summary>
  /// menuHelp
  /// </summary>
  public String? MenuHelp { get ; set; }
  
  /// <summary>
  /// bEncrypt
  /// </summary>
  public HexBinaryValue? BEncrypt { get ; set; }
  
  /// <summary>
  /// cmg
  /// </summary>
  public HexBinaryValue? Cmg { get ; set; }
  
}
