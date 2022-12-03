namespace DocumentModel.Wordprocessing;

/// <summary>
/// Custom XML Element Properties.
/// </summary>
public interface CustomXmlProperties // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Custom XML Element Placeholder Text.
  /// </summary>
  public String? CustomXmlPlaceholder { get ; set; }
  
  public Collection<CustomXmlAttribute>? CustomXmlAttributes { get ; set; }
  
}
