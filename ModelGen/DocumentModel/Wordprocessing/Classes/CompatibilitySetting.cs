namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the CompatibilitySetting Class.
/// </summary>
public partial class CompatibilitySetting
{
  
  /// <summary>
  ///   name
  /// </summary>
  public DocumentModel.Wordprocessing.CompatSettingNameKind? Name { get; set; }
  
  
  /// <summary>
  ///   uri
  /// </summary>
  public String? Uri { get; set; }
  
  
  /// <summary>
  ///   val
  /// </summary>
  public String? Val { get; set; }
  
}
