namespace DocumentModel.Drawings;

/// <summary>
/// Extension.
/// </summary>
public class ExtensionImpl: ModelElementImpl, Extension
{
  public DocumentFormat.OpenXml.Drawing.Charts.Extension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.Extension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Uniform Resource Identifier
  /// </summary>
  public String? Uri
  {
    get;
    set;
  }
  
}
