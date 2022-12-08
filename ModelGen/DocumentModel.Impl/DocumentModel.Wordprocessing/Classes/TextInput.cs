namespace DocumentModel.Wordprocessing;

/// <summary>
/// Text Box Form Field Properties.
/// </summary>
public class TextInputImpl: ModelElementImpl, TextInput
{
  public DocumentFormat.OpenXml.Wordprocessing.TextInput? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.TextInput?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
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
  
  /// <summary>
  /// Default Text Box Form Field String.
  /// </summary>
  public String? DefaultTextBoxFormFieldString
  {
    get;
    set;
  }
  
  /// <summary>
  /// Text Box Form Field Maximum Length.
  /// </summary>
  public Int16? MaxLength
  {
    get;
    set;
  }
  
  /// <summary>
  /// Text Box Form Field Formatting.
  /// </summary>
  public String? Format
  {
    get;
    set;
  }
  
}
