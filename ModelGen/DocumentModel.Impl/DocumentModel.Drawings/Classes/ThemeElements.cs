namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ThemeElements Class.
/// </summary>
public class ThemeElementsImpl: ModelElementImpl, ThemeElements
{
  public DocumentFormat.OpenXml.Drawing.ThemeElements? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ThemeElements?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// ColorScheme.
  /// </summary>
  public ColorScheme? ColorScheme
  {
    get;
    set;
  }
  
  /// <summary>
  /// Font Scheme.
  /// </summary>
  public FontScheme? FontScheme
  {
    get;
    set;
  }
  
  /// <summary>
  /// Format Scheme.
  /// </summary>
  public FormatScheme? FormatScheme
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
