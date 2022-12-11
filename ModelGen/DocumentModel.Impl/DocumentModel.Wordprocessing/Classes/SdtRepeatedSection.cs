namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SdtRepeatedSection Class.
/// </summary>
public class SdtRepeatedSectionImpl: ModelElementImpl, SdtRepeatedSection
{
  public DocumentFormat.OpenXml.Office2013.Word.SdtRepeatedSection? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Word.SdtRepeatedSection?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public SdtRepeatedSectionImpl(): base() {}
  
  public SdtRepeatedSectionImpl(DocumentFormat.OpenXml.Office2013.Word.SdtRepeatedSection openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// SectionTitle.
  /// </summary>
  public String? SectionTitle
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Word.SectionTitle>();
        return (String?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Word.SectionTitle>();
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
            item = new DocumentFormat.OpenXml.Office2013.Word.SectionTitle{ Val = (System.String?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// DoNotAllowInsertDeleteSection.
  /// </summary>
  public Boolean? DoNotAllowInsertDeleteSection
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Word.DoNotAllowInsertDeleteSection>();
        return (Boolean?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Word.DoNotAllowInsertDeleteSection>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.Boolean?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Office2013.Word.DoNotAllowInsertDeleteSection{ Val = (System.Boolean?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
}
