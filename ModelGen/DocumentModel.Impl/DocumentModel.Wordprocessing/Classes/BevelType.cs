namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the BevelType Class.
/// </summary>
public partial class BevelTypeImpl: ModelElementImpl, BevelType
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2010.Word.BevelType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Word.BevelType?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public BevelTypeImpl(): base() {}
  
  public BevelTypeImpl(DocumentFormat.OpenXml.Office2010.Word.BevelType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// w, this property is only available in Office 2010 and later.
  /// </summary>
  public Int64? Width
  {
    get => (System.Int64?)OpenXmlElement?.Width?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Width = (System.Int64?)value;
    }
  }
  
  /// <summary>
  /// h, this property is only available in Office 2010 and later.
  /// </summary>
  public Int64? Height
  {
    get => (System.Int64?)OpenXmlElement?.Height?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Height = (System.Int64?)value;
    }
  }
  
  /// <summary>
  /// prst, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Wordprocessing.BevelPresetKind? PresetProfileType
  {
    get => (DocumentModel.Wordprocessing.BevelPresetKind?)OpenXmlElement?.PresetProfileType?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.PresetProfileType = (DocumentFormat.OpenXml.Office2010.Word.BevelPresetTypeValues?)value;
    }
  }
  
}
