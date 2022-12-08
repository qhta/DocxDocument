namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Defines the RelativeWidth Class.
/// </summary>
public class RelativeWidthImpl: ModelElementImpl, RelativeWidth
{
  public DocumentFormat.OpenXml.Office2010.Word.Drawing.RelativeWidth? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Word.Drawing.RelativeWidth?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// relativeFrom, this property is only available in Office 2010 and later.
  /// </summary>
  public SizeRelativeHorizontallyKind? ObjectId
  {
    get => (SizeRelativeHorizontallyKind?)OpenXmlElement?.ObjectId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ObjectId = (DocumentFormat.OpenXml.Office2010.Word.Drawing.SizeRelativeHorizontallyValues?)value;
    }
  }
  
  /// <summary>
  /// PercentageWidth.
  /// </summary>
  public String? PercentageWidth
  {
    get;
    set;
  }
  
}
