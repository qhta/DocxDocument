namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the CompatibilitySetting Class.
/// </summary>
public class CompatibilitySettingImpl: ModelElementImpl, CompatibilitySetting
{
  public DocumentFormat.OpenXml.Wordprocessing.CompatibilitySetting? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.CompatibilitySetting?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
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
  
  /// <summary>
  /// uri
  /// </summary>
  public String? Uri
  {
    get;
    set;
  }
  
  /// <summary>
  /// val
  /// </summary>
  public String? Val
  {
    get;
    set;
  }
  
}
