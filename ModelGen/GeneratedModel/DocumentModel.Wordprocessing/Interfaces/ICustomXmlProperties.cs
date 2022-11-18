namespace DocumentModel.Wordprocessing;

/// <summary>
/// Custom XML Element Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ICustomXmlPlaceholder))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ICustomXmlAttribute))]
public interface ICustomXmlProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Custom XML Element Placeholder Text.
  /// </summary>
  public ICustomXmlPlaceholder? CustomXmlPlaceholder { get ; set; }
  
}
