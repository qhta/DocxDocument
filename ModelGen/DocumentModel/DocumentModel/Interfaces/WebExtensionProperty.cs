namespace DocumentModel;

/// <summary>
/// Defines the WebExtensionProperty Class.
/// </summary>
public interface WebExtensionProperty
{
  /// <summary>
  /// name, this property is only available in Office 2013 and later.
  /// </summary>
  public String? Name { get ; set; }
  
  /// <summary>
  /// value, this property is only available in Office 2013 and later.
  /// </summary>
  public String? Value { get ; set; }
  
}
