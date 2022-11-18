namespace DocumentModel.Spreadsheet;

/// <summary>
/// Credentials Method
/// </summary>
public enum CredentialsMethod
{
  /// <summary>
  /// Integrated Authentication.
  /// </summary>
  [XmlEnum("integrated")]
  Integrated,
  
  /// <summary>
  /// No Credentials.
  /// </summary>
  [XmlEnum("none")]
  None,
  
  /// <summary>
  /// Stored Credentials.
  /// </summary>
  [XmlEnum("stored")]
  Stored,
  
}
