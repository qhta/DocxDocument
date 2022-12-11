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
  
  public RelativeHeightImpl(): base() {}
  
  public RelativeHeightImpl(DocumentFormat.OpenXml.Office2010.Word.Drawing.RelativeHeight openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
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
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.Drawing.PercentageHeight>();
        return openXmlElement?.Text;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.Drawing.PercentageHeight>();
        if (item != null)
        {
          if (value is not null)
            item.Text = value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Office2010.Word.Drawing.PercentageHeight{ Text = value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
}
