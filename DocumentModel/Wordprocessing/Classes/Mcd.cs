namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the Mcd Class.
/// </summary>
public class Mcd
{
  /// <summary>
  ///   macroName
  /// </summary>
  public String? MacroName { get; set; }

  /// <summary>
  ///   name
  /// </summary>
  public String? Name { get; set; }

  /// <summary>
  ///   menuHelp
  /// </summary>
  public String? MenuHelp { get; set; }

  /// <summary>
  ///   bEncrypt
  /// </summary>
  public HexInt? BEncrypt { get; set; }

  /// <summary>
  ///   cmg
  /// </summary>
  public HexBinary? Cmg { get; set; }
}