namespace DocumentModel;

/// <summary>
/// OpenXmlLoadMode - load mode, default is Lazy
/// </summary>
public enum OpenXmlLoadMode
{
  /// <summary>
  /// Load all the OpenXmlElements recursively
  /// </summary>
  Full,
  
  /// <summary>
  /// Load only one layer element, cache OuterXml
  /// </summary>
  Lazy,
  
}
