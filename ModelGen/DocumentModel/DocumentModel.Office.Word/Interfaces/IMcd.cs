namespace DocumentModel.Office.Word;

/// <summary>
/// Defines the Mcd Class.
/// </summary>
public interface IMcd // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// macroName
  /// </summary>
  public System.String? MacroName { get ; set; }
  
  /// <summary>
  /// name
  /// </summary>
  public System.String? Name { get ; set; }
  
  /// <summary>
  /// menuHelp
  /// </summary>
  public System.String? MenuHelp { get ; set; }
  
  /// <summary>
  /// bEncrypt
  /// </summary>
  public DocumentModel.IHexBinaryValue? BEncrypt { get ; set; }
  
  /// <summary>
  /// cmg
  /// </summary>
  public DocumentModel.IHexBinaryValue? Cmg { get ; set; }
  
}
