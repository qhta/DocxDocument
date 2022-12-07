namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the CompatibilitySetting Class.
/// </summary>
public class CompatibilitySettingImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.CompatibilitySetting>, CompatibilitySetting
{
  /// <summary>
  /// name
  /// </summary>
  public CompatSettingNameKind? Name
  {
    get => (CompatSettingNameKind?)OpenXmlElement?.Name?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Name = (DocumentFormat.OpenXml.Wordprocessing.CompatSettingNameValues?)value;
    }
  }
  
}
