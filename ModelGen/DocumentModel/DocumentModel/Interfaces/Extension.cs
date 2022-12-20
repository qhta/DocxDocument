namespace DocumentModel;

/// <summary>
/// Defines the Extension Class.
/// </summary>
public partial interface Extension
{
  /// <summary>
  /// uri, this property is only available in Office 2021 and later.
  /// </summary>
  public String? Uri { get; set; }
  
}
