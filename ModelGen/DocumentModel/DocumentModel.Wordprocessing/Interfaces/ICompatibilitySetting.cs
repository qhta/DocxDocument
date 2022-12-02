namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the CompatibilitySetting Class.
/// </summary>
public interface ICompatibilitySetting // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// name
  /// </summary>
  public CompatSettingNameKind? Name { get ; set; }
  
  /// <summary>
  /// uri
  /// </summary>
  public String? Uri { get ; set; }
  
  /// <summary>
  /// val
  /// </summary>
  public String? Val { get ; set; }
  
}
