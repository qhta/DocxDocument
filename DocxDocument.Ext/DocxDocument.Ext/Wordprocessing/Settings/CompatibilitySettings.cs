namespace DocumentModel.Wordprocessing;

/// <summary>
/// This is a collection of <see cref="CompatibilitySetting"/> items. 
/// It has no corresponding DocumentFormat.OpenXml.Wordprocessing class.
/// Instead items of DocumentFormat.OpenXml.Wordprocessing.CompatiblitySetting type 
/// are included directly in DocumentFormat.OpenXml.Wordprocessing.Compatibility element.
/// </summary>
public partial class CompatibilitySettings
{
  public CompatibilitySettings(DXW.Compatibility openXmlElement)
  {
    _Element = openXmlElement;
  }

  internal DXW.Compatibility _Element { get; private set; }
}
