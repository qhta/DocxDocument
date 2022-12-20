namespace DocumentModel.Wordprocessing;

/// <summary>
/// Text Box Form Field Properties.
/// </summary>
public partial class TextInputImpl: ModelElementImpl, TextInput
{
  public DocumentFormat.OpenXml.Wordprocessing.TextInput? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.TextInput?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public TextInputImpl(): base() {}
  
  public TextInputImpl(DocumentFormat.OpenXml.Wordprocessing.TextInput openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Text Box Form Field Type.
  /// </summary>
  public DocumentModel.Wordprocessing.TextBoxFormFieldKind? TextBoxFormFieldType
  {
    get => (DocumentModel.Wordprocessing.TextBoxFormFieldKind?)OpenXmlElement?.TextBoxFormFieldType?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.TextBoxFormFieldType != null)
        {
          if (value is not null)
            OpenXmlElement.TextBoxFormFieldType.Val = (DocumentFormat.OpenXml.Wordprocessing.TextBoxFormFieldValues?)value;
          else
            OpenXmlElement.TextBoxFormFieldType = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.TextBoxFormFieldType = new DocumentFormat.OpenXml.Wordprocessing.TextBoxFormFieldType{ Val = (DocumentFormat.OpenXml.Wordprocessing.TextBoxFormFieldValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Default Text Box Form Field String.
  /// </summary>
  public String? DefaultTextBoxFormFieldString
  {
    get => (System.String?)OpenXmlElement?.DefaultTextBoxFormFieldString?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.DefaultTextBoxFormFieldString != null)
        {
          if (value is not null)
            OpenXmlElement.DefaultTextBoxFormFieldString.Val = (System.String?)value;
          else
            OpenXmlElement.DefaultTextBoxFormFieldString = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.DefaultTextBoxFormFieldString = new DocumentFormat.OpenXml.Wordprocessing.DefaultTextBoxFormFieldString{ Val = (System.String?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Text Box Form Field Maximum Length.
  /// </summary>
  public Int16? MaxLength
  {
    get => (System.Int16?)OpenXmlElement?.MaxLength?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.MaxLength != null)
        {
          if (value is not null)
            OpenXmlElement.MaxLength.Val = (System.Int16?)value;
          else
            OpenXmlElement.MaxLength = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.MaxLength = new DocumentFormat.OpenXml.Wordprocessing.MaxLength{ Val = (System.Int16?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Text Box Form Field Formatting.
  /// </summary>
  public String? Format
  {
    get => (System.String?)OpenXmlElement?.Format?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Format != null)
        {
          if (value is not null)
            OpenXmlElement.Format.Val = (System.String?)value;
          else
            OpenXmlElement.Format = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.Format = new DocumentFormat.OpenXml.Wordprocessing.Format{ Val = (System.String?)value };
        }
      }
    }
  }
  
}
