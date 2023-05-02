namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the Mcd Class.
/// </summary>
public class Mcd: ModelElement
{
  /// <summary>
  ///   macroName
  /// </summary>
  public string? MacroName { get; set; }

  /// <summary>
  ///   name
  /// </summary>
  public string? Name { get; set; }

  /// <summary>
  ///   menuHelp
  /// </summary>
  public string? MenuHelp { get; set; }

  /// <summary>
  ///   bEncrypt
  /// </summary>
  public HexChar? BEncrypt { get; set; }

  /// <summary>
  ///   cmg
  /// </summary>
  public HexChar? Cmg { get; set; }
}