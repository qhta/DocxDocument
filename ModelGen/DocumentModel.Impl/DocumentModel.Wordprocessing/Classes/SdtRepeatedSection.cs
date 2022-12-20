namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SdtRepeatedSection Class.
/// </summary>
public partial class SdtRepeatedSectionImpl: ModelElementImpl, SdtRepeatedSection
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2013.Word.SdtRepeatedSection? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Word.SdtRepeatedSection?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
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
    get => (System.String?)OpenXmlElement?.SectionTitle?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.SectionTitle != null)
        {
          if (value is not null)
            OpenXmlElement.SectionTitle.Val = (System.String?)value;
          else
            OpenXmlElement.SectionTitle = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.SectionTitle = new DocumentFormat.OpenXml.Office2013.Word.SectionTitle{ Val = (System.String?)value };
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
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Word.DoNotAllowInsertDeleteSection>();
        return item != null;
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
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Office2013.Word.DoNotAllowInsertDeleteSection();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
}
