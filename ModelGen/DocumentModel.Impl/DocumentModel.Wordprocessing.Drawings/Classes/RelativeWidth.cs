namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Defines the RelativeWidth Class.
/// </summary>
public partial class RelativeWidthImpl: ModelElementImpl, RelativeWidth
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2010.Word.Drawing.RelativeWidth? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Word.Drawing.RelativeWidth?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public RelativeWidthImpl(): base() {}
  
  public RelativeWidthImpl(DocumentFormat.OpenXml.Office2010.Word.Drawing.RelativeWidth openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// relativeFrom, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Wordprocessing.Drawings.SizeRelativeHorizontallyKind? ObjectId
  {
    get => (DocumentModel.Wordprocessing.Drawings.SizeRelativeHorizontallyKind?)OpenXmlElement?.ObjectId?.Value;
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
    get => (System.String?)OpenXmlElement?.PercentageWidth?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.PercentageWidth != null)
        {
          if (value is not null)
            OpenXmlElement.PercentageWidth.Text = value;
          else
            OpenXmlElement.PercentageWidth = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.PercentageWidth = new DocumentFormat.OpenXml.Office2010.Word.Drawing.PercentageWidth{ Text = value };
        }
      }
    }
  }
  
}
