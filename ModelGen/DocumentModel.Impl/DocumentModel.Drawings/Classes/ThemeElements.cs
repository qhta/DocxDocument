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
  public DocumentModel.Drawings.ColorScheme? ColorScheme
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Font Scheme.
  /// </summary>
  public DocumentModel.Drawings.FontScheme? FontScheme
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Format Scheme.
  /// </summary>
  public DocumentModel.Drawings.FormatScheme? FormatScheme
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawings.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
