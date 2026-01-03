namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the Mcd Class.
/// </summary>
public interface Mcd: IModelElement
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
  public IHexChar? BEncrypt { get; set; }
  /// <summary>
  ///   cmg
  /// </summary>
  public IHexChar? Cmg { get; set; }
}