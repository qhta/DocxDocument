namespace DocumentModel.Wordprocessing;

/// <summary>
/// Text Box Form Field Properties.
/// </summary>
public class TextInputImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.TextInput>, TextInput
{
  /// <summary>
  /// Text Box Form Field Type.
  /// </summary>
  public TextBoxFormFieldKind? TextBoxFormFieldType
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TextBoxFormFieldType>();
        return (TextBoxFormFieldKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TextBoxFormFieldType>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Wordprocessing.TextBoxFormFieldValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Wordprocessing.TextBoxFormFieldType{ Val = (DocumentFormat.OpenXml.Wordprocessing.TextBoxFormFieldValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
}
