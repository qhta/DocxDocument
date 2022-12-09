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
    get => (String?)OpenXmlElement?.Name?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Name = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Major Font.
  /// </summary>
  public MajorFont? MajorFont
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Minor fonts.
  /// </summary>
  public MinorFont? MinorFont
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList4? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
