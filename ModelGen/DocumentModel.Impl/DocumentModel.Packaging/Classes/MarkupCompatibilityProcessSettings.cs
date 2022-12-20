namespace DocumentModel.Packaging;

/// <summary>
/// Represents markup compatibility processing settings.
/// </summary>
public partial class MarkupCompatibilityProcessSettingsImpl: ModelObjectImpl, MarkupCompatibilityProcessSettings
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Packaging.MarkupCompatibilityProcessSettings? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.MarkupCompatibilityProcessSettings?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public MarkupCompatibilityProcessSettingsImpl(): base() {}
  
  public MarkupCompatibilityProcessSettingsImpl(DocumentFormat.OpenXml.Packaging.MarkupCompatibilityProcessSettings openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Gets the markup compatibility process mode.
  /// </summary>
  public DocumentModel.Packaging.MarkupCompatibilityProcessMode? ProcessMode
  {
    get => (DocumentModel.Packaging.MarkupCompatibilityProcessMode?)OpenXmlElement?.ProcessMode;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.MarkupCompatibilityProcessSettings).GetProperty("ProcessMode")?.SetValue(OpenXmlElement, (DocumentFormat.OpenXml.Packaging.MarkupCompatibilityProcessMode?)value);
    }
  }
  
  /// <summary>
  /// Gets the target file format versions.
  /// </summary>
  public DocumentModel.FileFormatVersions? TargetFileFormatVersions
  {
    get => (DocumentModel.FileFormatVersions?)OpenXmlElement?.TargetFileFormatVersions;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.MarkupCompatibilityProcessSettings).GetProperty("TargetFileFormatVersions")?.SetValue(OpenXmlElement, (DocumentFormat.OpenXml.FileFormatVersions?)value);
    }
  }
  
}
