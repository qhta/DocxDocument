namespace DocumentModel.Drawings;

/// <summary>
/// Font Scheme.
/// </summary>
public class FontSchemeImpl: ModelElement<DocumentFormat.OpenXml.Drawing.FontScheme>, FontScheme
{
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
