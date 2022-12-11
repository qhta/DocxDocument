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
  
  public ThemeElementsImpl(): base() {}
  
  public ThemeElementsImpl(DocumentFormat.OpenXml.Drawing.ThemeElements openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// ColorScheme.
  /// </summary>
  public ColorScheme? ColorScheme
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Font Scheme.
  /// </summary>
  public FontScheme? FontScheme
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Format Scheme.
  /// </summary>
  public FormatScheme? FormatScheme
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
