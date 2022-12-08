namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the BevelType Class.
/// </summary>
public class BevelTypeImpl: ModelElementImpl, BevelType
{
  public DocumentFormat.OpenXml.Office2010.Word.BevelType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Word.BevelType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// w, this property is only available in Office 2010 and later.
  /// </summary>
  public Int64? Width
  {
    get;
    set;
  }
  
  /// <summary>
  /// h, this property is only available in Office 2010 and later.
  /// </summary>
  public Int64? Height
  {
    get;
    set;
  }
  
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
