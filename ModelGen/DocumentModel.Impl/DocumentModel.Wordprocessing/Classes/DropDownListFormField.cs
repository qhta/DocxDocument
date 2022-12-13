namespace DocumentModel.Wordprocessing;

/// <summary>
/// Drop-Down List Form Field Properties.
/// </summary>
public class DropDownListFormFieldImpl: ModelElementImpl, DropDownListFormField
{
  public DocumentFormat.OpenXml.Wordprocessing.DropDownListFormField? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.DropDownListFormField?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public DropDownListFormFieldImpl(): base() {}
  
  public DropDownListFormFieldImpl(DocumentFormat.OpenXml.Wordprocessing.DropDownListFormField openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Drop-Down List Selection.
  /// </summary>
  public Int32? DropDownListSelection
  {
    get => (System.Int32?)OpenXmlElement?.DropDownListSelection?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.DropDownListSelection != null)
        {
          if (value is not null)
            OpenXmlElement.DropDownListSelection.Val = (System.Int32?)value;
          else
            OpenXmlElement.DropDownListSelection = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.DropDownListSelection = new DocumentFormat.OpenXml.Wordprocessing.DropDownListSelection{ Val = (System.Int32?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Default Drop-Down List Item Index.
  /// </summary>
  public Int32? DefaultDropDownListItemIndex
  {
    get => (System.Int32?)OpenXmlElement?.DefaultDropDownListItemIndex?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.DefaultDropDownListItemIndex != null)
        {
          if (value is not null)
            OpenXmlElement.DefaultDropDownListItemIndex.Val = (System.Int32?)value;
          else
            OpenXmlElement.DefaultDropDownListItemIndex = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.DefaultDropDownListItemIndex = new DocumentFormat.OpenXml.Wordprocessing.DefaultDropDownListItemIndex{ Val = (System.Int32?)value };
        }
      }
    }
  }
  
  public String? ListEntryFormField
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ListEntryFormField>();
        return (System.String?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ListEntryFormField>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.String?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.ListEntryFormField{ Val = (System.String?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
}
