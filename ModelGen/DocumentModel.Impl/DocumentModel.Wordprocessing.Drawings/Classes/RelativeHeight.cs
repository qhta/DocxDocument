namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Defines the RelativeHeight Class.
/// </summary>
public class RelativeHeightImpl: ModelElementImpl, RelativeHeight
{
  public DocumentFormat.OpenXml.Office2010.Word.Drawing.RelativeHeight? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Word.Drawing.RelativeHeight?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// relativeFrom, this property is only available in Office 2010 and later.
  /// </summary>
  public SizeRelativeVerticallyKind? RelativeFrom
  {
    get => (SizeRelativeVerticallyKind?)OpenXmlElement?.RelativeFrom?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.RelativeFrom = (DocumentFormat.OpenXml.Office2010.Word.Drawing.SizeRelativeVerticallyValues?)value;
    }
  }
  
  /// <summary>
  /// PercentageHeight.
  /// </summary>
  public String? PercentageHeight
  {
    get;
    set;
  }
  
}
