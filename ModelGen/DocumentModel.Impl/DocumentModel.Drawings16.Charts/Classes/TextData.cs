namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the TextData Class.
/// </summary>
public class TextDataImpl: ModelElementImpl, TextData
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TextData? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TextData?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public TextDataImpl(): base() {}
  
  public TextDataImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TextData openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public DocumentModel.Drawings16.Charts.OpenXmlFormulaElement? Formula
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public String? VXsdstring
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.VXsdstring>();
        return openXmlElement?.Text;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.VXsdstring>();
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
            item = new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.VXsdstring{ Text = value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
}
