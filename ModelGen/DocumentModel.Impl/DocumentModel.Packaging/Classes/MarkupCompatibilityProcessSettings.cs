namespace DocumentModel.Packaging;

/// <summary>
/// Represents markup compatibility processing settings.
/// </summary>
public class MarkupCompatibilityProcessSettingsImpl: ModelObjectImpl, MarkupCompatibilityProcessSettings
{
  public DocumentFormat.OpenXml.Packaging.MarkupCompatibilityProcessSettings? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.MarkupCompatibilityProcessSettings?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Gets the markup compatibility process mode.
  /// </summary>
  public MarkupCompatibilityProcessMode? ProcessMode
  {
    get => (MarkupCompatibilityProcessMode?)OpenXmlElement?.ProcessMode;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.MarkupCompatibilityProcessSettings).GetProperty("ProcessMode").SetValue(OpenXmlElement, (DocumentFormat.OpenXml.Packaging.MarkupCompatibilityProcessMode?)value);
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
        typeof(DocumentFormat.OpenXml.Packaging.MarkupCompatibilityProcessSettings).GetProperty("TargetFileFormatVersions").SetValue(OpenXmlElement, (DocumentFormat.OpenXml.FileFormatVersions?)value);
    }
  }
  
}
