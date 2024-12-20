namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Defines the RelativeHeight Class.
/// </summary>
public partial class RelativeHeightImpl: ModelElementImpl, RelativeHeight
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2010.Word.Drawing.RelativeHeight? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Word.Drawing.RelativeHeight?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public RelativeHeightImpl(): base() {}
  
  public RelativeHeightImpl(DocumentFormat.OpenXml.Office2010.Word.Drawing.RelativeHeight openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// relativeFrom, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Wordprocessing.Drawings.SizeRelativeVerticallyKind? RelativeFrom
  {
    get => (DocumentModel.Wordprocessing.Drawings.SizeRelativeVerticallyKind?)OpenXmlElement?.RelativeFrom?.Value;
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
    get => (System.String?)OpenXmlElement?.PercentageHeight?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.PercentageHeight != null)
        {
          if (value is not null)
            OpenXmlElement.PercentageHeight.Text = value;
          else
            OpenXmlElement.PercentageHeight = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.PercentageHeight = new DocumentFormat.OpenXml.Office2010.Word.Drawing.PercentageHeight{ Text = value };
        }
      }
    }
  }
  
}
