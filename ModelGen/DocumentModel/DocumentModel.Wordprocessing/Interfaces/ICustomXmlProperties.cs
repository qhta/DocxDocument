namespace DocumentModel.Wordprocessing;

/// <summary>
/// Custom XML Element Properties.
/// </summary>
public interface ICustomXmlProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Custom XML Element Placeholder Text.
  /// </summary>
  public String? CustomXmlPlaceholder { get ; set; }
  
  public Collection<ICustomXmlAttribute>? CustomXmlAttributes { get ; set; }
  
}
