namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the CompatibilitySetting Class.
/// </summary>
public interface ICompatibilitySetting // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// name
  /// </summary>
  public DocumentModel.Wordprocessing.CompatSettingNameKind? Name { get ; set; }
  
  /// <summary>
  /// uri
  /// </summary>
  public System.String? Uri { get ; set; }
  
  /// <summary>
  /// val
  /// </summary>
  public System.String? Val { get ; set; }
  
}
