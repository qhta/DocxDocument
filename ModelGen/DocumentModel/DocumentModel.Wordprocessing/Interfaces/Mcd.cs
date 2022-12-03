namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Mcd Class.
/// </summary>
public interface Mcd // : System.Boolean
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
  public DocumentModel.HexBinaryValue? BEncrypt { get ; set; }
  
  /// <summary>
  /// cmg
  /// </summary>
  public DocumentModel.HexBinaryValue? Cmg { get ; set; }
  
}
