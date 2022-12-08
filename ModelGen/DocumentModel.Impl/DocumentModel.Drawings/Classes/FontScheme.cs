namespace DocumentModel.Drawings;

/// <summary>
/// Font Scheme.
/// </summary>
public class FontSchemeImpl: ModelElementImpl, FontScheme
{
  public DocumentFormat.OpenXml.Drawing.FontScheme? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.FontScheme?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Name
  /// </summary>
  public String? Name
  {
    get;
    set;
  }
  
  /// <summary>
  /// Major Font.
  /// </summary>
  public MajorFont? MajorFont
  {
    get;
    set;
  }
  
  /// <summary>
  /// Minor fonts.
  /// </summary>
  public MinorFont? MinorFont
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList1? ExtensionList
  {
    get;
    set;
  }
  
}
