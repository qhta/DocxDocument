namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SchemeColor Class.
/// </summary>
public class SchemeColorImpl: ModelElementImpl, SchemeColor
{
  public DocumentFormat.OpenXml.Office2010.Word.SchemeColor? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Word.SchemeColor?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public SchemeColorKind? Val
  {
    get => (SchemeColorKind?)OpenXmlElement?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Val = (DocumentFormat.OpenXml.Office2010.Word.SchemeColorValues?)value;
    }
  }
  
  public Collection<Int32>? Tints
  {
    get;
    set;
  }
  
  public Collection<Int32>? Shades
  {
    get;
    set;
  }
  
  public Collection<Int32>? Alphas
  {
    get;
    set;
  }
  
  public Collection<Int32>? HueModulations
  {
    get;
    set;
  }
  
  public Collection<Int32>? Saturations
  {
    get;
    set;
  }
  
  public Collection<Int32>? SaturationOffsets
  {
    get;
    set;
  }
  
  public Collection<Int32>? SaturationModulations
  {
    get;
    set;
  }
  
  public Collection<Int32>? Luminances
  {
    get;
    set;
  }
  
  public Collection<Int32>? LuminanceOffsets
  {
    get;
    set;
  }
  
  public Collection<Int32>? LuminanceModulations
  {
    get;
    set;
  }
  
}
