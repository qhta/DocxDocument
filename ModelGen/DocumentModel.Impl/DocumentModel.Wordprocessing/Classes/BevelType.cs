namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the BevelType Class.
/// </summary>
public class BevelTypeImpl: ModelElement<DocumentFormat.OpenXml.Office2010.Word.BevelType>, BevelType
{
  /// <summary>
  /// prst, this property is only available in Office 2010 and later.
  /// </summary>
  public BevelPresetKind? PresetProfileType
  {
    get => (BevelPresetKind?)OpenXmlElement?.PresetProfileType?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.PresetProfileType = (DocumentFormat.OpenXml.Office2010.Word.BevelPresetTypeValues?)value;
    }
  }
  
}
