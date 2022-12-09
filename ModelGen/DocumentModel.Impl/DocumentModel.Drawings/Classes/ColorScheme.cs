namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ColorScheme Class.
/// </summary>
public class ColorSchemeImpl: ModelElementImpl, ColorScheme
{
  public DocumentFormat.OpenXml.Drawing.ColorScheme? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ColorScheme?)_OpenXmlElement;
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
  /// Dark 1.
  /// </summary>
  public Dark1Color? Dark1Color
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Light 1.
  /// </summary>
  public Light1Color? Light1Color
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Dark 2.
  /// </summary>
  public Dark2Color? Dark2Color
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Light 2.
  /// </summary>
  public Light2Color? Light2Color
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Accent 1.
  /// </summary>
  public Accent1Color? Accent1Color
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Accent 2.
  /// </summary>
  public Accent2Color? Accent2Color
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Accent 3.
  /// </summary>
  public Accent3Color? Accent3Color
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Accent 4.
  /// </summary>
  public Accent4Color? Accent4Color
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Accent 5.
  /// </summary>
  public Accent5Color? Accent5Color
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Accent 6.
  /// </summary>
  public Accent6Color? Accent6Color
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Hyperlink.
  /// </summary>
  public Hyperlink? Hyperlink
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Followed Hyperlink.
  /// </summary>
  public FollowedHyperlinkColor? FollowedHyperlinkColor
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
