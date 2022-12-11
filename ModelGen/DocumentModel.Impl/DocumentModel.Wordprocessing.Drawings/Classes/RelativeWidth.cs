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
  
  public RelativeWidthImpl(): base() {}
  
  public RelativeWidthImpl(DocumentFormat.OpenXml.Office2010.Word.Drawing.RelativeWidth openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
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
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.Drawing.PercentageWidth>();
        return openXmlElement?.Text;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.Drawing.PercentageWidth>();
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
            item = new DocumentFormat.OpenXml.Office2010.Word.Drawing.PercentageWidth{ Text = value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
}
