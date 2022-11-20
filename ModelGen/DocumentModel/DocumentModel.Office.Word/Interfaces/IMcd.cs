namespace DocumentModel.Office.Word;

/// <summary>
/// Defines the Mcd Class.
/// </summary>
public interface IMcd // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// macroName
  /// </summary>
  public string? MacroName { get ; set; }
  
  /// <summary>
  /// name
  /// </summary>
  public string? Name { get ; set; }
  
  /// <summary>
  /// menuHelp
  /// </summary>
  public string? MenuHelp { get ; set; }
  
  /// <summary>
  /// bEncrypt
  /// </summary>
  public IHexBinaryValue? BEncrypt { get ; set; }
  
  /// <summary>
  /// cmg
  /// </summary>
  public IHexBinaryValue? Cmg { get ; set; }
  
}
