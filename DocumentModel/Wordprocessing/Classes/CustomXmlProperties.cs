namespace DocumentModel.Wordprocessing;

/// <summary>
/// Custom XML Element Properties.
/// </summary>
public partial class CustomXmlProperties
{
  /// <summary>
  /// Custom XML Element Placeholder Text.
  /// </summary>
  public String? CustomXmlPlaceholder { get; set; }
  
  public Collection<DocumentModel.Wordprocessing.CustomXmlAttribute>? CustomXmlAttributes { get; set; }
  
}
