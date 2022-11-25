namespace DocumentModel.Wordprocessing;

/// <summary>
/// Legacy Numbering Level Properties.
/// </summary>
public interface ILegacyNumbering // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Use Legacy Numbering Properties
  /// </summary>
  public System.Boolean? Legacy { get ; set; }
  
  /// <summary>
  /// Legacy Spacing
  /// </summary>
  public System.String? LegacySpace { get ; set; }
  
  /// <summary>
  /// Legacy Indent
  /// </summary>
  public System.String? LegacyIndent { get ; set; }
  
}
